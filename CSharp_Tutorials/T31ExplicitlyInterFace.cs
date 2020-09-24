using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public interface T31ExplicitlyInterFace
    {
       void print1();
    }
   public interface IinterFacedup2
   {
       void print1();
   }
   public class implementation : T31ExplicitlyInterFace, IinterFacedup2
   {
      public void print1() //if TWO interfaces conatains the method with same name and implemented this method then while calling this method ambiguity will created. 
       {
           Console.WriteLine("Just check");
       }
      // You can use the Interface Explicitly method to aoid this ambiguity.

      void T31ExplicitlyInterFace.print1() // this is called Explicitly interface implementation.
          // then you not need to define any access modifier.
      {
          Console.WriteLine("Interface 1 is called");
      }
   }
    }
