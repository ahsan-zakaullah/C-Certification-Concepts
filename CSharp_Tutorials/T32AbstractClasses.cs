using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public abstract class T32AbstractClasses // abstract class cannot be SEALED 
    {
       // You cannot create the instance of the abstract class.

       // use the abstract keyword to create the abstract class.
       public abstract void method(); // abstract method have no implementions 
       public void methodimp() // abstract class can have the method without ABSTRACT keyword which have the implemention as well.
       {
           Console.WriteLine("Having no abstract keyword;");
       }
   }
   public abstract class abstractClass:T32AbstractClasses
   {
       public abstract void method1();
   }
   public class abstractImplementation : abstractClass
   {
       public override void method1()
       {
           Console.WriteLine("Method one  is implemented");
       }
       public override void method()
       {
           Console.WriteLine("Method one  is implemented");
       }
   }
}
