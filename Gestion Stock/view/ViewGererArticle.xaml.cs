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
using Gestion_Stock.ViewModel;
using System.ComponentModel;

namespace Gestion_Stock.View
{
    /// <summary>
    /// Interaction logic for ViewGererArticle.xaml
    /// </summary>
    public partial class ViewGererArticle : Window
    {
        public ViewGererArticle(InMemoryDB db)
        {
            InitializeComponent();
            base.DataContext = new ViewModel.VMArticle(new DaoInMemoryArticle(db));
            
        }

        public object MessageBox { get; internal set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //MessageBoxResult messageBoxResult = MessageBox.Show(new PropertyChangedEventArgs(ViewModel.VMArticle._status ));
        }
    }
}
