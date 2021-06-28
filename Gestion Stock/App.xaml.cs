using Gestion_Stock.Infrastructure;
using Gestion_Stock.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Gestion_Stock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        //ViewGestionArticles viewGestionArticles;
       MainMenu viewMainMenu;

        public App()
        {
            viewMainMenu  = new MainMenu();
            viewMainMenu.Show();
        }

    }
}
