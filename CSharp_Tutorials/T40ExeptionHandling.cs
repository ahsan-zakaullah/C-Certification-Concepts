using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CSharp_Tutorials
{
    public class T40ExeptionHandling
    {
        public static void method()
        {
            StreamReader sr = null;
            try
            {
                // You can write the blick of the code which may got the exeptions.
                sr = new StreamReader(@"D:\Important.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fe) // this is the derived class from EXEPTION class...
            {
                Console.WriteLine(fe.FileName);
            }

            catch (Exception ex) // You cannot write the base class before the derived class.. Because it will get all the exption in this class the no need to call the other class.
            {
                Console.WriteLine(ex.Message);// Here you can show the exeption message.
                Console.WriteLine(ex.StackTrace); // You can find the line where exeptions occurs.
            }

            finally
            {
                if (sr != null)
                {
                    sr.Close(); // Use the finally block to free the resources.
                }
                Console.WriteLine("Finally Block.");
                }
        }
    }
}
