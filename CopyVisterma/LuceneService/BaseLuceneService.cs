using Lucene.Net.Documents;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visterma.Core.LuceneService
{
    class BaseLuceneService <T> where T: class
    {

        private static T _mapLuceneDocumentToData(Document doc)
        {
            return null;
        }

        private static IEnumerable<T> _mapLuceneToDataList(IEnumerable<Document> hits)
        {
            return hits.Select(_mapLuceneDocumentToData).ToList();  //Pamietaj i tym!!!!!!!!!!!!!!!!!!
        }

        private static IEnumerable<T> _mapLuceneToDataList(IEnumerable<ScoreDoc> hits,
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
    }
}
