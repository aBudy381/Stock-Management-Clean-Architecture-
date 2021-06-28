using Gestion_Stock.Service;
using RitegeMonitoring.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Gestion_Stock.ViewModel
{
    class VMArticle : ViewModelBase
    {
        #region DATA
        private string _id;
        private string _quantite;
        private string _label;
        private IDaoArticle _dao;
        private string _status;
        #endregion

        #region Properties
        public string ID
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }
       

        public string Quantite
        {
            get { return _quantite; }
            set
            {
                _quantite = value;
                OnPropertyChanged(nameof(Quantite));
            }
        }

        #endregion

        #region Command
        public ICommand CmdSave { get; set; }
        public ICommand CmdCancel { get; set; }
        public ICommand CmdUpdate { get; set; }
        public ICommand CmdSupprimer { get; set; }

        #endregion

        #region Constructor
        public VMArticle(IDaoArticle dao)
        {
            CmdSave = new RelayCommand(Save);
            CmdCancel = new RelayCommand(Cancel);
            CmdUpdate=new RelayCommand(Update);
            CmdSupprimer= new RelayCommand(Delete);
            _dao = dao;

        }

        private void Delete(object obj)
        {
            Console.WriteLine("gg");
            try
            {
                if (
                   _dao.DeleteArticle(new Model.Article { ID = ID, Label = Label, Quantite = Quantite }))
                    Status = "product deleted";
                    //MessageBoxResult messageBoxResult = MessageBox.Show(new PropertyChangedEventArgs(Status));
                else Status = "product not deleted";
            }
            catch (Exception e)
            {

                Status = "error with product deletion";
            }

        }

        #endregion

        #region Method
        private void Cancel(object obj)
        {
            
        }

        private void Save(object obj)
        {
            try
            {if (
                _dao.SaveArticle(new Model.Article { ID = ID, Label = Label, Quantite = Quantite }))
                    Status = "product added";
            else Status = "product exists";
            }
            catch (Exception e)
            {

                Status = "product could not be added";
            }
            
        }
        private void Update(object obj)
        {
            try
            {if
              (  _dao.UpdateArticle(new Model.Article { ID = ID, Label = Label, Quantite = Quantite }))
                    Status = "updated";
                else Status = "error";


            }
            catch (Exception e)
            {

                Status= "update error: " + e.Message;
            }

        }
        #endregion
    }
}
