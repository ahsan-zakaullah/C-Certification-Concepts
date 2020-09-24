using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void multicastDelgate();
public delegate int multicastDelgatewithReturn();
public delegate void multicastDelgatewithOutParameter(out int number);
namespace CSharp_Tutorials
{
    class T39MultiCastDelegates
    {
        public static void method1()
        {
            Console.WriteLine("Method 1 is called.");
        }
        public static void method2()
        {
            Console.WriteLine("Method 2 is called.");
        }

        public static int method3()
        {
            return 3;
        }
        public static int method4()
        {
            return 4;
        }

        public static void method5( out int number)
        {
            number=5;
        }
        public static void method6(out int number)
        {
            number = 6;
        }
    }
}
