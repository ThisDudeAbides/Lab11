using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public Person()
        {

        }
        public Person(string n, string a)
        {
            Name = n;
            Address = a;
        }

        public override string ToString()
        {
            return Name + " " + Address;
        }

    }
}
