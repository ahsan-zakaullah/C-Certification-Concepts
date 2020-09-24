using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
    public class T15ForAndForeachLOOP
    {
        public void method()
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("ENter the values of Arrays:" + i);
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            foreach (int k in array)
            {
                
                if (k % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(k);
            }
        }
    }
}
