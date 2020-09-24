using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    public class T16Methods
    {
        public int add(int a, int b)
        {
            int result1;
            bool result = int.TryParse("a + b", out result1);
            if (result)
            {
                Console.WriteLine(result1);
            }
            return result1;
        }
        public static void show(int target)
        {
            int [] array=new int[3];
            array[0]=12;
            array[1]=23;
            array[2]=34;
            foreach (int k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}
