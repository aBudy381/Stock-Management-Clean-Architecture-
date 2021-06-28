using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Stock.Model;

namespace Service
{
    public interface IDaoDB

    {

        String Ajouter(Article article);
        bool Modifier(Article article);
        void Supprimer(Article article);
        List<Article> RecupererArticles();

    }

}
