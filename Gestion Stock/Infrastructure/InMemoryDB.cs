using Gestion_Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Infrastructure
{
    public class InMemoryDB
    {
        public List<Article> articles;

        public InMemoryDB()
        {
            articles = new List<Article>();
            articles.Add(new Article { ID = "20", Label = "Article1", Quantite = "10" });
            articles.Add(new Article { ID = "21", Label = "Article2", Quantite = "20" });
            articles.Add(new Article { ID = "22", Label = "Article3", Quantite = "30" });
            articles.Add(new Article { ID = "23", Label = "Article4", Quantite = "5" });
            articles.Add(new Article { ID = "24", Label = "Article5", Quantite = "1" });
        }
    }
}
