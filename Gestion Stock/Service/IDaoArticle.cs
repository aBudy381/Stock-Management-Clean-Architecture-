using Gestion_Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Service
{
    interface IDaoArticle
    {
        Boolean SaveArticle(Article currentArticle);
        Boolean UpdateArticle(Article currentArticle);
        List<Article> SaveArticle();
        bool DeleteArticle(Article article);
    }
}
