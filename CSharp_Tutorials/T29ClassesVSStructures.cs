using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
   public class T29ClassesVSStructures
    {
       // Struct have the value type variable
       int i = 0;
      // where classes have the reference types like string,delegates
       // Struct store on STACK in memory..
       // While classes store on heap in memory..
       // in Struct value type destroyed immedialtly after the use..
       // while in class the refernce remove but object will remain in the memory.
       //struct have no destructor but classes have.
       //struct not have the prameter less constructor but class can have..
       //Struct cannot b ineherited but classes can.
       //both can implement in interfaces.
       //You can use the SEALED keyword to disable the class from inheretance.
    }
}
