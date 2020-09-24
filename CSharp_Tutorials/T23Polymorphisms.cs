using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T23Polymorphisms
    {
        // Polymorphism is to invoke the derived class method with the instance of the base class at run time it is called ploymorphisms...
        public string Fname;
       public string Lname;

       public virtual void print1() // If you want to override the method in derived class then you should call it VIRTUAL
       {
           Console.WriteLine(Fname + Lname);
       }
    }
   public class DerivedClass3 : T23Polymorphisms
   {

       public override void print1() // Use OVERRIDE keyword to replace with method of base class ..
       {
           Console.WriteLine("Based Class 13 Methods");
            
       }
       
    }
   
    public class DerivedClass2 : T23Polymorphisms
   {

       public override void print1() // Use OVERRIDE keyword to replace with method of base class.
       {
           Console.WriteLine("Based Class 2 Methods");

       }

   }
}
