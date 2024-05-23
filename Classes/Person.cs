using System.ComponentModel;

namespace PROIECTWAP.Classes
{
    [Serializable]
     public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _phoneNumber;
        private string _gender;
        private int _age;
        private string _address;

        public Person()
        {
        }

        public Person(string name, string phoneNumber, string address, int age, string gender)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _age = age;
            _gender = gender;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber)); }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(nameof(Gender)); }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(nameof(Age)); }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
