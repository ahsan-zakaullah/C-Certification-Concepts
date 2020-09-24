using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project;

namespace CSharp_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter:");
            //int n=0;
            //bool num = int.TryParse(Console.ReadLine(),out n);
           
            ////Console.Write(n);
            //if (n == 0 && n == 3)
            //{
            //    Console.Write("| condition");
            //}

            //T15ForAndForeachLOOP t = new T15ForAndForeachLOOP();
            //t.method();
            //int i = 23;
            //int sum = 0;
            //int product = 0;
            //T16Methods t16 = new T16Methods();
            //T17MethodsTypes t17 = new T17MethodsTypes();
            //Console.WriteLine(t17.add(ref i, 44));
            //t17.addmethod(12,3,out sum,out product);
            //Console.WriteLine("SUm={0},product={1}", sum, product);
            ////T16Methods.show(3);
            //Project.TeamA.method1(); // Using Fully Qulified name


           // DerivedClass d = new DerivedClass();
           // d.Fname = "Ahsan";
           // d.Lname = "Raza";
           //Console.WriteLine("Salary is:::"+ d.salary(30000));
           // d.print();

            //DerivedClass1 d = new DerivedClass1();
            //d.Fname = "Ahsan";
            //d.Lname = "Raza";
            //Console.WriteLine("Salary is:::" + d.salary(30000));
            //d.print1();
            //((T22MethodHiding)d).print1();

            //T22MethodHiding d = new DerivedClass1(); // Instance of the parent class can b created by using this way..
            //// You cannot create the drived class instacne using the base class object.

            //// Now when you call method then method of base class whould be called.
            //d.print1();


            //T23Polymorphisms[] ploy = new T23Polymorphisms[3];
            //ploy[0] = new T23Polymorphisms(); // Using the instance of the base class call method of the child class.
            //ploy[1] = new DerivedClass3();
            //ploy[2] = new DerivedClass2();

            //foreach (T23Polymorphisms p in ploy)
            //{
            //    p.print1();
            //}
            //T26Properties t = new T26Properties();
            //t.setFname("Ahsan Raza");
            //t.setLname("Jajja");
            //Console.WriteLine("FName={0},LastName={1}", t.getName(),t.getLName());

            //T27SetandGETProperties t = new T27SetandGETProperties();
            //t.First_Name="Ahsan Raza";
            //t.Last_name="Jajja";
            //Console.WriteLine("FName={0},LastName={1}",t.First_Name,t.Last_name);

            //T28Structures s = new T28Structures
            //{
            //    FirstName = "AHSAN ",
            //    LastName = "RAZA"

            //};
            //s.printname();

            //T36Delegats t = new T36Delegats();
            //t.printmethod();

            //List<T37DelegatesUsage> t1 = new List<T37DelegatesUsage>();
            //t1.Add(new T37DelegatesUsage { Id=1,name="Ahsan",salary=1000,Experince=2});
            //t1.Add(new T37DelegatesUsage { Id=2,name="Raza",salary=3000,Experince=6});
            //t1.Add(new T37DelegatesUsage { Id=3,name="Saad",salary=4000,Experince=7});
            //T37DelegatesUsage.promoteemployee(t1);
        
            //================39====================//

            //multicastDelgate md = new multicastDelgate(T39MultiCastDelegates.method1);  // Delegates does not contain a constructor that takes 0 arguments.
            //multicastDelgate md2 = new multicastDelgate(T39MultiCastDelegates.method2);
            //md += md2; // You can use the add(+) operator to call the multiple functions.  
            //md(); // call delegates.
            //multicastDelgatewithReturn md3 = new multicastDelgatewithReturn(T39MultiCastDelegates.method3);
            //multicastDelgatewithReturn md4 = new multicastDelgatewithReturn(T39MultiCastDelegates.method4);
            //md3 += md4; // In Multicasting Delegates, if the function have return type and you call the multiple delegates then return value would be 
            //            // the value of last invoked function.
            //Console.WriteLine(md3());

            //multicastDelgatewithOutParameter md5 = new multicastDelgatewithOutParameter(T39MultiCastDelegates.method5);
            //multicastDelgatewithOutParameter md6 = new multicastDelgatewithOutParameter(T39MultiCastDelegates.method6);
            //md6 += md5; // If the delegate have the OUT parameters then result will be the last invoked functions. 
            //int numberhaveOut = -1;
            //md6(out numberhaveOut);
            //Console.WriteLine("Out Number is = {0}", numberhaveOut);

            //==============40==================//

            //T40ExeptionHandling.method();
            //==============41==================//

           //T41InnerExaption.method();
           //==============42==================//

            //try
            //{
            //    throw new T42CustomExeptionsSerialable("Throw Expetions");
            //}
            //catch (T42CustomExeptionsSerialable cus)
            //{
            //    Console.WriteLine(cus.Message);
            //}

            
            //==============43==================//
            //T43ExepHandlingAbuse.method();
            //==============44==================//
            //T44ExpHandlingAbuseSolved.method();
            //==============43==================//
            T45WhyEnums[] whyEnum=new T45WhyEnums[3];
            whyEnum[0] = new T45WhyEnums
            {
                Name = "ahsan",
                Gender = 1
            };
            whyEnum[1] = new T45WhyEnums
            {
                Name = "Raza",
                Gender = 2
            };
            whyEnum[2] = new T45WhyEnums
            {
                Name = "Ram",
                Gender = 0
            };
            foreach (T45WhyEnums whyEnums in whyEnum)
            {
                Console.WriteLine("Name={0} and Gender is = {1}", whyEnums.Name, getGender( whyEnums.Gender)); 
            }
           
        }
        public static string getGender(int g)
        {
            switch (g)
            {
                case 0 :
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Not valid";
            }
        }
    }
}
