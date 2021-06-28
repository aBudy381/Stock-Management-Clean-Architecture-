using Gestion_Stock.Model;
using Gestion_Stock.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Infrastructure
{
    class DaoInMemoryArticles : IDaoArticles
    {
        private InMemoryDB db;

        public DaoInMemoryArticles(InMemoryDB db)
        {
            this.db = db;
        }

        public List<Article> GetArticles()
        {
            return db.articles;
        }
    }
}
