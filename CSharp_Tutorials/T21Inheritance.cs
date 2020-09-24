using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public  class T21Inheritance
    {
       public string Fname;
       public string Lname;
       // When you create the instnce of the derived class then parent class constructor call first then derived class constructor calls.
       //Multiple Inheritance is not possible in C#.
       //But MultiLevel Inheretance is possible..
       public T21Inheritance()
       {
           Console.WriteLine("Base Class Constructor");
       }
       public T21Inheritance(string msg)
       {
           Console.WriteLine(msg);
       }
       public void print()
       {
           Console.WriteLine(Fname + Lname);
       }
    }
   public class DerivedClass : T21Inheritance
   {
       public DerivedClass():base("Which you want") // Using the BASE key word you can call constructor of the parent on your choice.
       {
           Console.WriteLine("Derived Class Construtor Calls...!!");
       }
       public int salary(int sa)
       {
           return sa;
       }
       }
}
