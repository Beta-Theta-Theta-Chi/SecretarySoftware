using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryJawn
{
    class SecretaryViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Brother> BrothersList{ get; set; }

        public SecretaryViewModel()
        {
            BrothersList = new ObservableCollection<Brother>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
