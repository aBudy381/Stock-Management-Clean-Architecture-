using Gestion_Stock.Infrastructure;
using Gestion_Stock.Model;
using Gestion_Stock.Service;
using Gestion_Stock.View;
using RitegeMonitoring.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.ViewModel
{
    class VMArticlList : ViewModelBase
    {
        private DaoInMemoryArticles daoInMemoryArticles;
        private List<Article> articles;
        private IDaoArticles daoArticles;
        private MainMenu viewMainMenu;

        public RelayCommand CmdTotal { get; }
        public RelayCommand CmdBack { get; }

        private readonly IDaoArticle daoArticle;

        public VMArticlList(IDaoArticles daoArticles)
        {
            this.daoArticles = daoArticles;
            CmdTotal = new RelayCommand(Total);
            CmdBack = new RelayCommand(Back);
            articles = daoArticles.GetArticles();
        }
        public List<Article> Articles
        {
            get => articles;
            set
            {
                articles = value;
                OnPropertyChanged(nameof(Articles));
            }

        }

        private void Rafraichir(object obj)
        {
            Articles = daoArticles.GetArticles();
        }
        private void Total(object obj)
        {
            int total = 0;
            //Articles = daoArticles.GetArticles();
            for (int i = 0; i < Articles.Count; i++)
            {
                //Console.WriteLine(Articles[i]);
                total += 12;
            }
        }

        private void Back(object obj)
        {
            viewMainMenu = new MainMenu();
            viewMainMenu.Show();
        }
    }
}
