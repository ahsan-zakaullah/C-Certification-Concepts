using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void HellotoFunction(string msg); // Create the delegate. it same like method with having DELEGATE keyword
namespace CSharp_Tutorials
{
    public class T36Delegats
    {
        // DELEGATE is a safe type FUNCTION POINTER
        //mean a method will called which have the same return type and signature with the delegate.
        public static void Delegmethod(string a)
        {
            Console.WriteLine(a);
        }
        public void printmethod()
        {
            HellotoFunction h = new HellotoFunction(Delegmethod); // You need to give the name of the method which you want to point is delegates.
            h("Funcation called");
        }
    }
}
