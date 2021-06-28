using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.model
{
    public class GererStock
    { private List<Article> ListArticle = new List<Article>();
    public void ajouterArticle(Article articletoadd)
        {
            ListArticle.Add(articletoadd);
        }
       // public void modifierArticle(Article)
    }
}
