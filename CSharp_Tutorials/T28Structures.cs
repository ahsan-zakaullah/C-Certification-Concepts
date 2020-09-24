using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public struct T28Structures
    {
       
        private string Fname; // You can hide your variable data using the PRIVATE keyword. it is also called encapsulations

        public string FirstName
        {
            get { return Fname; }
            set { Fname = value; }
        }
        private string Lname;

        public string LastName
        {
            get { return Lname; }
            set { Lname = value; }
        }
        public T28Structures(string _fname, string _lname)
        {
            this.Fname = _fname;
            this.Lname = _lname;

        }
       public void printname()
        {
            Console.WriteLine(this.Fname + this.Lname);
        }
    }
}
