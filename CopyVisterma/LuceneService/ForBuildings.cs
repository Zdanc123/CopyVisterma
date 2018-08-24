using CopyVisterma.Entities;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Visterma.Core.LuceneService
{
    class ForBuildings
    {
        private static string _luceneDir = @"~/StaticFiles/BuildingsIndex";
        private static FSDirectory _directoryTemp;
        private static FSDirectory _directory
        {
            get
            {
                if (_directoryTemp == null)
                    _directoryTemp = FSDirectory.Open(new System.IO.DirectoryInfo(_luceneDir));
                if (IndexWriter.IsLocked(_directoryTemp)) IndexWriter.Unlock(_directoryTemp);

                var lockFilePath = Path.Combine(_luceneDir, "write.lock");
                if (File.Exists(lockFilePath))
                    File.Delete(lockFilePath);
                return _directoryTemp;
            }

        }


        private static void _addToLuceneIndex(Building building, IndexWriter writer)
        {
            // remove older index entry
            var searchQuery = new TermQuery(new Term("Id", building.Id.ToString()));
            writer.DeleteDocuments(searchQuery);

            // add new index entry
            var doc = new Document();

            // add lucene fields mapped to db fields
            doc.Add(new Field("Id", building.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("Street", building.Street, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("Number", building.Number, Field.Store.YES, Field.Index.NOT_ANALYZED));
            //doc.Add(new Field("NumberOfApartments", building.NumberOfApartments.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("PostalCode", building.PostalCode, Field.Store.YES, Field.Index.NOT_ANALYZED));

            // add entry to index
            writer.AddDocument(doc);
        }

        public static void AddUpdateLuceneIndex(IEnumerable<Building> buildings)
        {
            // init lucene

            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                // add data to lucene search index (replaces older entry if any)
                foreach (var building in buildings) _addToLuceneIndex(building, writer);

                // close handles
                analyzer.Close();
                writer.Dispose();
            }

            
        }

        public static void AddUpdateLuceneIndex(Building building)
        {
            AddUpdateLuceneIndex(new List<Building> { building });
        }

        public static void ClearLuceneIndexRecord(int record_id)
        {
            // init lucene
            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                // remove older index entry
                var searchQuery = new TermQuery(new Term("Id", record_id.ToString()));
                writer.DeleteDocuments(searchQuery);

                // close handles
                analyzer.Close();
                writer.Dispose();
            }
        }


        public static bool ClearLuceneIndex()
        {
            try
            {
                var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
                using (var writer = new IndexWriter(_directory, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED))
                {
                    // remove older index entries
                    writer.DeleteAll();

                    // close handles
                    analyzer.Close();
                    writer.Dispose();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        private static Building _mapLuceneDocumentToData(Document doc)
        {
            return new Building
            {
                Id = Convert.ToInt32(doc.Get("Id")),
                Street = doc.Get("Street"),
                Number = doc.Get("Number"),
               // NumberOfApartments =Convert.ToInt32( doc.Get("NumberOfApartments ")),
                PostalCode = doc.Get("PostalCode")
                

            };

            
        }

        private static IEnumerable<Building> _mapLuceneToDataList(IEnumerable<Document> hits)
        {
            return hits.Select(_mapLuceneDocumentToData).ToList();  //Pamietaj i tym!!!!!!!!!!!!!!!!!!
        }

        private static IEnumerable<Building> _mapLuceneToDataList(IEnumerable<ScoreDoc> hits,
       IndexSearcher searcher)
        {
            return hits.Select(hit => _mapLuceneDocumentToData(searcher.Doc(hit.Doc))).ToList();
        }

        private static Query parseQuery(string searchQuery, QueryParser parser)
        {
            Query query;
            try
            {
                query = parser.Parse(searchQuery.Trim());
            }
            catch (ParseException)
            {
                query = parser.Parse(QueryParser.Escape(searchQuery.Trim()));
            }
            return query;
        }

        private static IEnumerable<Building> _search(string searchQuery, string searchField = "")
        {
            // validation
            if (string.IsNullOrEmpty(searchQuery.Replace("*", "").Replace("?", ""))) return new List<Building>();

            // set up lucene searcher
            using (var searcher = new IndexSearcher(_directory, true))
            {
                var hits_limit = 1000;
                var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

                
                var parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, " Street" , analyzer);
                var query = parseQuery(searchQuery, parser);
                var hits = searcher.Search(query, hits_limit).ScoreDocs;
                var results = _mapLuceneToDataList(hits, searcher);
                analyzer.Close();
                searcher.Dispose();
                return results;
                
            }
   
        }

        public static IEnumerable<Building> Search(string input, string fieldName = "")
        {
            if (string.IsNullOrEmpty(input)) return GetAllIndexRecords();

            var terms = input.Trim().Replace("-", " ").Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
            input = string.Join(" ", terms);

            return _search(input, fieldName);
        }

        public static IEnumerable<Building> GetAllIndexRecords()
        {
            // validate search index
            if (!System.IO.Directory.EnumerateFiles(_luceneDir).Any()) return new List<Building>();

            // set up lucene searcher
            var searcher = new IndexSearcher(_directory, true);
            var reader = IndexReader.Open(_directory, true);
            var docs = new List<Document>();
            var term = reader.TermDocs();
            while (term.Next()) docs.Add(searcher.Doc(term.Doc));
            reader.Dispose();
            searcher.Dispose();
            return _mapLuceneToDataList(docs);
        }


    }
}
