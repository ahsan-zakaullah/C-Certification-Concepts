using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T37DelegatesUsage
    {
       public int Id { set; get; }
       public string name { set; get; }
       public int salary { set; get; }
       public int Experince { set; get; }
       public delegate bool isPrmotable(T37DelegatesUsage emp1);

       public static void promoteemployee(List<T37DelegatesUsage> employeelist, isPrmotable promote)
       {
           foreach (T37DelegatesUsage emply in employeelist) 
           {
               if (promote(emply)) // Here is the HARD CODED logic to promote the employee. We need delegate to GENRIC it.
               {
                   Console.WriteLine(emply.name + " Is promoted");
               }
           }
       }
    }
}
