using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    class T44ExpHandlingAbuseSolved
    {

        public static void method()
        {
            try
            {
                Console.WriteLine("Enter the First Number:");
                int nenumerator;
                // This is Proper way to resolve the Exeption handling abuse. 
                bool IsTrue=Int32.TryParse(Console.ReadLine(), out nenumerator);
                if (IsTrue)
                {

                    Console.WriteLine("Enter the Second Number:");
                    int Dnenumerator;

                    bool IsTrueD = Int32.TryParse(Console.ReadLine(), out Dnenumerator);
                    if (IsTrueD && Dnenumerator != 0)
                    {
                        int result = nenumerator / Dnenumerator;

                        Console.WriteLine("Result is = {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divided by ZERO");
                    }
                }
                else {
                    Console.WriteLine("Enter Valid Number");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}