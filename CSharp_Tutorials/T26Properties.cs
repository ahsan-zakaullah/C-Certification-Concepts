using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T26Properties
    {
        private string Fname; // You can hide your variable data using the PRIVATE keyword. it is also called encapsulations
        private string Lname;
       // You can set the values of the private variable by using the SETTER and GETTER method.
        public void setFname(string _fname) 
        {
            if (string.IsNullOrEmpty(_fname))
            {
                throw new Exception("Name cannot b null or empty");
            }
            else
                this.Fname = _fname;
        }
        public string getName()
        {
           return string.IsNullOrEmpty(this.Fname)?"Not name":this.Fname;
        }

        public void setLname(string _lname) 
        {
            if (string.IsNullOrEmpty(_lname))
            {
                throw new Exception("Name cannot b null or empty");
            }
            else
                this.Lname = _lname;
        }
        public string getLName()
        {
            return string.IsNullOrEmpty(this.Lname) ? "Not name" : this.Lname;
        }
    }
}
