using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T34ProblemInMultipleInheritance
    {
       // class2 and class 3 inherited from class1(T34...) and class4 inherited from both class2 and class3. 
       //So this is called DAIMOND PROBLEM
       // That's why we cannot use the multiple class inheritance
       public virtual void method()
       {
           Console.WriteLine("method");
       }
    }
   public class class2:T34ProblemInMultipleInheritance
   {
       public override void method()
       {
           Console.WriteLine("method");
       }
   }
   public class Class3:class2
   {
       public override void method()
       {
           Console.WriteLine("method");
       }
   }
   //public class class4:class2,Class3 // Not allowd multiple inheritance
   //{
   //    public override void method()
   //    {
   //        Console.WriteLine("method");
   //    }
   //}
}
