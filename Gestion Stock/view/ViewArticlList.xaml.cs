using Gestion_Stock.Infrastructure;
using Gestion_Stock.Service;
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
    /// Interaction logic for ViewArticlList.xaml
    /// </summary>
    public partial class ViewArticlList : Window
    {
        public ViewArticlList(InMemoryDB db)
        {
            InitializeComponent();
            base.DataContext = new ViewModel.VMArticlList(new DaoInMemoryArticles(db));
            //articles = daoArticles.GetArticles();
        }

        public void BTotal_Click(object sender, RoutedEventArgs e) {
            TotalInput = new TextBox();
            TotalInput.Text = "Default text";

        }
        public void BBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }



    }
}
