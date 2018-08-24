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
    public static class ForClients
    {
        private static string _luceneDir = @"C:\Users\Praktyka\Desktop\Index22";
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

        private static void _addToLuceneIndex(Client client, IndexWriter writer)
        {
            // remove older index entry
            var searchQuery = new TermQuery(new Term("Id", client.Id.ToString()));
            writer.DeleteDocuments(searchQuery);

            // add new index entry
            var doc = new Document();

            // add lucene fields mapped to db fields
            doc.Add(new Field("Id", client.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("Name", client.Name, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("NIP", client.NIP, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("Phone", client.Phone, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("Email", client.Email, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("City", client.City, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("BuildingNumber", client.BuildingNumber, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("ApartmentNumber", client.ApartmentNumber, Field.Store.YES, Field.Index.NOT_ANALYZED));
            

            // add entry to index
            writer.AddDocument(doc);
        }

        public static void AddUpdateLuceneIndex(IEnumerable<Client> clients)
        {
            // init lucene

            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                // add data to lucene search index (replaces older entry if any)
                foreach (var client in clients) _addToLuceneIndex(client, writer);

                // close handles
                analyzer.Close();
                writer.Dispose();
            }
        }

        public static void AddUpdateLuceneIndex(Client client)
        {
            AddUpdateLuceneIndex(new List<Client> { client });
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

        private static Client _mapLuceneDocumentToData(Document doc)
        {
            return new Client
            {
                Id = Convert.ToInt32(doc.Get("Id")),
                Name = doc.Get("Name"),
                NIP = doc.Get("NIP"),
                Phone = doc.Get("Phone"),
                Email = doc.Get("Email"),
                City = doc.Get("City"),
                BuildingNumber = doc.Get("BuildingNumber"),
                ApartmentNumber = doc.Get("NumberOfApartments "),
                
            };
        }

        private static IEnumerable<Client> _mapLuceneToDataList(IEnumerable<Document> hits)
        {
            return hits.Select(_mapLuceneDocumentToData).ToList();  //Pamietaj i tym!!!!!!!!!!!!!!!!!!
        }

        private static IEnumerable<Client> _mapLuceneToDataList(IEnumerable<ScoreDoc> hits,
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

        private static IEnumerable<Client> _search(string searchQuery, string searchField = "")
        {
            // validation
            if (string.IsNullOrEmpty(searchQuery.Replace("*", "").Replace("?", ""))) return new List<Client>();

            // set up lucene searcher
            using (var searcher = new IndexSearcher(_directory, true))
            {
                var hits_limit = 1000;
                var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);


                var parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, " Street", analyzer);
                var query = parseQuery(searchQuery, parser);
                var hits = searcher.Search(query, hits_limit).ScoreDocs;
                var results = _mapLuceneToDataList(hits, searcher);
                analyzer.Close();
                searcher.Dispose();
                return results;

            }

        }

        public static IEnumerable<Client> Search(string input, string fieldName = "")
        {
            if (string.IsNullOrEmpty(input)) return GetAllIndexRecords();

            var terms = input.Trim().Replace("-", " ").Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
            input = string.Join(" ", terms);

            return _search(input, fieldName);
        }

        public static IEnumerable<Client> GetAllIndexRecords()
        {
            // validate search index
            if (!System.IO.Directory.EnumerateFiles(_luceneDir).Any()) return new List<Client>();

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
