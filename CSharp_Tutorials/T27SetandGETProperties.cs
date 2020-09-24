using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    class T27SetandGETProperties
    {
        private string Fname; // You can hide your variable data using the PRIVATE keyword. it is also called encapsulations
        private string Lname;
        // You can set the values of the private variable by using the builtin SETTER and GETTER method.
        public string First_Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot b null or empty");
                }
                else
                    this.Fname = value; // value keyword automatically get from the user end.
            }
            get
            {
                return string.IsNullOrEmpty(this.Fname) ? "Not name" : this.Fname;
            }  
      }

        public string Last_name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot b null or empty");
                }
                else
                    this.Lname = value;
            }
            get
            {
                return string.IsNullOrEmpty(this.Lname) ? "Not name" : this.Lname;
            }
        }
    }
}
