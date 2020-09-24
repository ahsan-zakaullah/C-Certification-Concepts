using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T24andT25MethodoverLoading
    {
       public void print1()
       {
           Console.WriteLine("Based Class 13 Methods");

       }
       public void print1(int a)
       {
           Console.WriteLine("Based Class 13 Methods"+a);

       }
       public void print1(float a) //you can overloading the method bby giving the different datatype,different parameters.
       {
           Console.WriteLine("Based Class 13 Methods" + a);
       }
       public void print1(out float a) //you can overloading the method by giving in or out parameters.
       {
           int sum = 0;
           a = sum;
           Console.WriteLine("Based Class 13 Methods" + a);
       }
       // You cannot overloading the method by different RETURN type and not use the "PRAMAS" keyword. 
    }
}
