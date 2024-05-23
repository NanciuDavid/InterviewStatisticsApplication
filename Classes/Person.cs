using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    internal class Person
    {
        private string _name;
        private string _phoneNumber;
        private string _gender;
        private int _age;
        private String _address;

        public Person()
        {
        }

        public Person(string name, string phoneNumber, string gender, int age, string address          )
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _gender = gender;
            _age = age;
            _address = address;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
