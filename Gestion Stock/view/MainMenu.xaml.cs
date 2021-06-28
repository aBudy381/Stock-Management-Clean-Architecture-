using Gestion_Stock.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gestion_Stock.View
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        ViewGestionArticles viewGestionArticles;
        ViewArticlList list_articles ;

        public MainMenu()
        {
            InitializeComponent();
            base.DataContext = new ViewModel.VMMainMenu();
            
        }

        private void viewbutton_Click(object sender, RoutedEventArgs e)
        {
            // this.Close();
            /*viewGestionArticles = new ViewGestionArticles(new InMemoryDB());
            viewGestionArticles.Show();*/
            list_articles = new ViewArticlList(new InMemoryDB());
            list_articles.Show();

        }
        private void managebutton_Click(object sender, RoutedEventArgs e)
        {
             this.Close();
            viewGestionArticles = new ViewGestionArticles(new InMemoryDB());
            viewGestionArticles.Show();
           // list_articles = new ViewArticlList(new InMemoryDB());
            //list_articles.Show();

        }
    }
}
