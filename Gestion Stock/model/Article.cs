using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.Model
{
    public class Article
    {
        public string ID { get; set; }
        public string Label { get; set; }
        public string Quantite { get; set; }
        public string getQuantite()
        {
            return Quantite;
        }

    }
}
