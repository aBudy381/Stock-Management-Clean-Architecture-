using Gestion_Stock.Infrastructure;
using Gestion_Stock.Model;
using Gestion_Stock.View;
using RitegeMonitoring.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Stock.ViewModel
{
    class VMMainMenu : ViewModelBase 
    {
        //ViewGestionArticles viewGestionArticles;
        #region Command
        public ICommand CmdView { get; set; }
        public ICommand CmdManage { get; set; }

        #endregion
        public VMMainMenu()
        {
            CmdView = new RelayCommand(View);
            CmdManage = new RelayCommand(Manage);
        }

        private void View(object obj)
        {
           

        }
        private void Manage(object obj)
        {


        }
    }
}
