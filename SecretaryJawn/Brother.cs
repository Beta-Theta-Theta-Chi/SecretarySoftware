using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryJawn
{
    class Brother:INotifyPropertyChanged
    {

        public Brother()
        {
            firstName = "Brother_FirstName_Not_Specified";
            lastName = "Brother_LastName_Not_Specified";
            phoneNumber = "PhoneNumber_Not_Specified";
            major = "Major_Not_Specified";
        }
        private string firstName { get; set; }

        private string lastName { get; set; }

        private string phoneNumber { get; set; }

        private string major { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if(lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if(phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                if(major != value)
                {
                    major = value;
                    OnPropertyChanged("Major");
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
