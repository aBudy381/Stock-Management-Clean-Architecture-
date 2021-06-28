
using System;
using System.ComponentModel;
using System.Diagnostics;

using System.Windows.Input;

namespace RitegeMonitoring.Helper
{

    public class ViewModelBase : INotifyPropertyChanged
    {
        
        public ICommand PropertyChangedCmd { get ; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModelBase()
        {
            
        }
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
            if(PropertyChangedCmd != null)
            {
                PropertyChangedCmd.Execute(name);
            }
        }
    }
}
