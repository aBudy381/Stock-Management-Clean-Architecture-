
using Gestion_Stock.Model;
using Gestion_Stock.Service;
using Gestion_Stock.View;

using RitegeMonitoring.Helper;
using Service;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Stock.ViewModel
{
    class VMGererArticles : ViewModelBase
    {

        #region DATA
        private List<Article> articles;
        private IDaoArticles daoArticles;
        private IDaoArticle daoArticle;

        //DBConnection db = DBConnection.GetDBInstance("server=localhost; database=stages; Uid=root; pwd=''");
        //MySqlDataAdapter adapter;
        //IDaoDB dbarticles;
        #endregion

        #region Properties

        public List<Article> Articles
        {
            get => articles;
            set
            {
                articles = value;
                OnPropertyChanged(nameof(Articles));
            }
        }
        #endregion

        #region Command

        public ICommand CmdAjouter { get; set; }
        public ICommand CmdModifier { get; set; }
        public ICommand CmdSupprimer { get; set; }
        public ICommand CmdRafraichir { get; set; }
        
        #endregion

        #region Constructor
        public VMGererArticles(IDaoArticles daoArticles)
        {
            this.daoArticles = daoArticles;
            CmdAjouter = new RelayCommand(Ajouter);
            CmdModifier = new RelayCommand(Modifier);
            CmdSupprimer = new RelayCommand(Supprimer);
            CmdRafraichir = new RelayCommand(Rafraichir);
            articles = daoArticles.GetArticles();
        }

        

        #endregion

        #region Method

        private void Supprimer(object obj)
        {

        }

        private void Modifier(object obj)
        {
            
        }

        private void Ajouter(object obj)
        {
            // articles.Add(new Article { ID = "56", Label = "Article1", Quantite = "10"});
            

        }

        private void Rafraichir(object obj)
        {
            Articles = daoArticles.GetArticles();
        }
        #endregion
    }
}
