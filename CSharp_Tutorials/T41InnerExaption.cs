using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSharp_Tutorials
{
    public class T41InnerExaption
    {
        public static void method()
        {
            StreamWriter sw = null;
            try
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
                catch (Exception ex) // You cannot write the base class before the derived class.. Because it will get all the exption in this class the no need to call the other class.
                {
                    string filepath = @"D:\Logs.txt"; // Here you can create the log of the programs.

                    if (File.Exists(filepath))
                    {
                        sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        Console.WriteLine();
                        sw.Write(ex.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "File Not Found");
                    }
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }

            catch (Exception exp)
            {
                Console.WriteLine("Current Exeptions= {}", exp.GetType().Name); // It give the External expection
                if (exp.InnerException != null)
                {
                    Console.WriteLine("Inner Exeptions is={}", exp.InnerException.GetType().Name); // Here you need to specify the inner expetion value to get the expetion of inner one.
                }
            }
        }
    }
}