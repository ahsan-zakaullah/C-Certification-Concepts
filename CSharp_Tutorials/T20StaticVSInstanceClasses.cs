using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Tutorials
{
  public  class T20StaticVSInstanceClasses
    {
      public float Area;
      public static float _pi ;
      // Static Constructor should be call first than the instance Constructor
      // Static Constructor call automatically when class is start.
      // you cannot use instance or Object of the class to call the static method of the class.
      static T20StaticVSInstanceClasses()
      {
          Console.WriteLine("Static COnstroctor Called:");
          T20StaticVSInstanceClasses._pi = 3.14F;
      }
      public T20StaticVSInstanceClasses(float PI)
      {
          _pi = PI;
      }
      public void method(int r)
      {
          Area = _pi * r * r;
      }
    }
}
