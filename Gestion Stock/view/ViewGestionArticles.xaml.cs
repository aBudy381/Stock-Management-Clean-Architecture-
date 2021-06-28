using Gestion_Stock.Infrastructure;
using Gestion_Stock.Model;
using Gestion_Stock.ViewModel;
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
    /// Interaction logic for ViewGestionArticles.xaml
    /// </summary>
    public partial class ViewGestionArticles : Window
    {
        private InMemoryDB db;
        public ViewGestionArticles(InMemoryDB inMemoryDB)
        {
            db = inMemoryDB;
            InitializeComponent();
            base.DataContext =new  ViewModel.VMGererArticles(new DaoInMemoryArticles(
      db));
        }

        private void BModifier_Click(object sender, RoutedEventArgs e)
        {if (data.SelectedIndex > -1)
            {
                UpdateArticle viewGererArticle = new UpdateArticle(db);
                VMArticle vMArticle = (VMArticle)viewGererArticle.DataContext;
                vMArticle.ID = ((Article)data.SelectedItem).ID;
                vMArticle.Label = ((Article)data.SelectedItem).Label;
                vMArticle.Quantite = ((Article)data.SelectedItem).Quantite;
                viewGererArticle.ShowDialog();
                //this.Status.Text = vMArticle.Status;
                MessageBoxResult messageBoxResult = MessageBox.Show(this.Status.Text = vMArticle.Status);
                data.Items.Refresh();
            }
            else
                MessageBox.Show("selectionner un article");
        }

        private void BAjouter_Click(object sender, RoutedEventArgs e)
        {
            ViewGererArticle viewGererArticle = new ViewGererArticle(db);
            VMArticle vMArticle = (VMArticle)viewGererArticle.DataContext;
            
            viewGererArticle.ShowDialog();
            //this.Status.Text = vMArticle.Status;
            MessageBoxResult messageBoxResult = MessageBox.Show(this.Status.Text = vMArticle.Status);
            data.Items.Refresh();
        }

        private void BSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (data.SelectedIndex > -1)
            {
                DeleteArticle viewGererArticle = new DeleteArticle(db);
            VMArticle vMArticle = (VMArticle)viewGererArticle.DataContext;
            vMArticle.ID = ((Article)data.SelectedItem).ID;
            vMArticle.Label = ((Article)data.SelectedItem).Label;
            vMArticle.Quantite = ((Article)data.SelectedItem).Quantite;
            viewGererArticle.ShowDialog();
                //this.Status.Text = vMArticle.Status;
                MessageBoxResult messageBoxResult = MessageBox.Show(this.Status.Text = vMArticle.Status);

            }
            else
                MessageBox.Show("selectionner un article");
        }

        private void BRafraichir_Click(object sender, RoutedEventArgs e)
        {
            //this.Status.Text = "refreshed";
            MessageBoxResult messageBoxResult = MessageBox.Show(this.Status.Text = "refreshed");
            //data.Items.Refresh();
        }
    }
}
