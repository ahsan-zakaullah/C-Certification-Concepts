using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public interface T35MultipleInheritanceUsingInterface
    {
       void print();
    }
   public class a : T35MultipleInheritanceUsingInterface
   {
       public void print()
       {
           Console.WriteLine("Class A");
       }
   }
   public interface interface2
   {
       void print2();
   }
   public class b : interface2
   {
       public void print2()
       {
           Console.WriteLine("Class B");
       }
   }
   public class AB : T35MultipleInheritanceUsingInterface, interface2 // Here you can implements the multiple interface on the class and the 
       // access the multiple classes under those interfaces.
       // So you can acheive the multiple inheritance
   {
       public void print()
       {
           a a = new a();
           a.print();
       }
       public void print2()
       {
           b a = new b();
           a.print2();
       }
   }
}
