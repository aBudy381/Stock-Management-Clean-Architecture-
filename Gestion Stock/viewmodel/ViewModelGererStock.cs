using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock.viewmodel
{
    class VMGererStock : ViewModelBase
    {
        #region Data
        private string _id;
        #endregion
        #region proprties
        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
            #endregion
        }

    }
}
