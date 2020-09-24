
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    public class T43ExepHandlingAbuse
    {
        public static void method()
        {
            try
            {
                Console.WriteLine("Enter the First Number:");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number:");
                int sn = Convert.ToInt32(Console.ReadLine());

                int result = fn / sn;
                Console.WriteLine("Result is = {0}", result);
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Please enter number {0} && {1}",Int32.MinValue,Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Not divide Zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valid Format");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
