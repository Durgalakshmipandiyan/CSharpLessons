using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class DemoA
    {
        //global declaration
        int x = 123; // member variable/ class variable/ field
            static int y = 567;
            public static void FirstMethod()
        {
           
            int x = 2000;  //Local variables
            int y = 5000;
            Console.WriteLine(x); //non static member cannot be acccessed
            Console.WriteLine(y); // local variable
            Console.WriteLine(DemoA.y); // global static variable
        }
        public static void SecondMethod()
        {
            // local var
            int y = 5000;
           // Console.WriteLine(x); // non static member can be accessed
            Console.WriteLine(y);
            Console.WriteLine(DemoA.y);
        }
    }

    internal class DemoB
    {

    }
}

namespace LessonA.Gavs
{
    internal class DemoA
    {

    }
}