using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

namespace CSharp_Tutorials
{
    [Serializable] // It use to convert the object to into packets to communicate over the network(means you can use it in more the applications). 
   public class T42CustomExeptionsSerialable :Exception
    {
       public T42CustomExeptionsSerialable(): base()
       {
       }

       public T42CustomExeptionsSerialable(string message)
           : base(message)
       {
       }

       public T42CustomExeptionsSerialable(string message, Exception innerException)
           : base(message,innerException)
       {
       }
       public T42CustomExeptionsSerialable(SerializationInfo info, StreamingContext context)
           : base(info,context)
       {
       }
    }
}
