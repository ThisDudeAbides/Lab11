
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Student : Person
   
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }
        public Student()
        {

        }
        public Student(string p, int yr, double money, string n, string a):base(n,a)
        {
            Program = p;
            Year = yr;
            Fee = money;
        } 
        public override string ToString()
        {
            return $"{Name} {Address} {program} {Year} {Fee}";
        }
    }
}
