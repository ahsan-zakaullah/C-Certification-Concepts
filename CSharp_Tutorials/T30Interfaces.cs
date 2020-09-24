using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public interface T30Interfaces
    {
       // int j = 0; // Interface cannot conatains fields
       void print(); // Interface method not have any specifier becuase it is PUBLIC by default.
    }
   public interface Iinterface2:T30Interfaces // Interface can also inherit another interface.
   {
       void print2(); // Interface have only declaration of the method and have no implementations of the method.
   }
   public class Implements : T30Interfaces, Iinterface2 // you can implement multiple interfaces in a class.
   {
       // You need to all interfaces methods in the implemented class.
       
       // You cannot create the instance of the interfaces.
       public void print()
       {
           Console.WriteLine("Print first interface;");
       }
       public void print2()
       {
           Console.WriteLine("Print 2 method");
       }
   }
}
