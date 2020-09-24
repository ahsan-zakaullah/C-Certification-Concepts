using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
  public class T19Classes
    {
      string Firstname = "", Lastname = "";
      // Constructor have no return types...
      public T19Classes(string _fname, string _lname)
      {
          Firstname = _fname;
          Lastname = _lname;
      }
      public void method()
      {
          Console.WriteLine("Full name is={0}", Firstname + Lastname);// {0} means the placeholders
      }
      ~T19Classes()
      {
          // Clean up your code using Destructor......
      }
    }
}
