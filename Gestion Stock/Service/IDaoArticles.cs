using Gestion_Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Service
{
    interface IDaoArticles
    {
        List<Article> GetArticles();

    }
}
