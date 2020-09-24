using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    public class T17MethodsTypes
    {
        public int add(ref int a, int b)
        {
            // Value Type: two different variable point to the 2 different memory location
            // reference type: two different variable point to the same memory location
            a = 12;
            
            int result1 = a + b;
            return result1;
        }

        public void addmethod(int a, int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
        }
        public void method(params int[] storeNumber)
        {
            Console.WriteLine("Araay {0}", storeNumber.Length);
            foreach (int k in storeNumber)
            {
                Console.WriteLine(k);
            }
        }
    }
}
