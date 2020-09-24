using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T22MethodHiding
    {
         public string Fname;
       public string Lname;
       // When you create the instnce of the derived class then parent class constructor call first then derived class constructor calls.
       //Multiple Inheritance is not possible in C#.
       //But MultiLevel Inheretance is possible..
       public T22MethodHiding()
       {
           Console.WriteLine("Base Class Constructor");
       }
       public T22MethodHiding(string msg)
       {
           Console.WriteLine(msg);
       }
       public void print1()
       {
           Console.WriteLine(Fname + Lname);
       }
    }
   public class DerivedClass1 : T22MethodHiding
   {
       public DerivedClass1():base("Which you want") // Using the BASE key word you can call constructor of the parent on your choice.
       {
           Console.WriteLine("Derived Class Construtor Calls...!!");
       }
       public int salary(int sa)
       {
           return sa;
       }
       public new void print1() // Method is override you can use the NEW keyword
       {
           //base.print1(); // You can also use this way call the base class method 
           Console.WriteLine("Method is override");
           
           //T22MethodHiding d = new DerivedClass1(); // Instance of the parent class can b created by using this way..

           // Now when you call method then method of base class whould be called.
            
       }
       }
    }