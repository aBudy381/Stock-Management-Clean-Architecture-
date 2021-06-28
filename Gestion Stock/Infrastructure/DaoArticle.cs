using Gestion_Stock.Model;
using Gestion_Stock.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gestion_Stock.Infrastructure
{
    public class DaoInMemoryArticle : IDaoArticle
    {
        private InMemoryDB db;

        public DaoInMemoryArticle(InMemoryDB db)
        {
            this.db = db;
        }

        public bool SaveArticle(Article currentArticle)
        {
            Article article = db.articles.Where(x => x.ID == currentArticle.ID).FirstOrDefault();
            if (article != null)
            {
                return false;
            }
            else db.articles.Add(currentArticle); return true;
        }

        public List<Article> SaveArticle()
        {
            throw new NotImplementedException();
        }

        public Boolean UpdateArticle(Article currentArticle)
        {
            
            Article article = db.articles.Where(x=> x.ID == currentArticle.ID).FirstOrDefault();
            if (article == null) 
                return false;
            else
            {
                article.Label = currentArticle.Label;
                article.Quantite = currentArticle.Quantite;
                return true;
            }
                
        }
        public bool DeleteArticle(Article currentArticle)
        {

            //Article article = db.articles.Where(x => x.ID == currentArticle.ID).FirstOrDefault();
            int xy = db.articles.RemoveAll(x => x.ID == currentArticle.ID);
            Console.WriteLine(xy);
            Console.WriteLine(currentArticle.ID);
            return xy>0;
            

        }
    }
}
