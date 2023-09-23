using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal abstract class Vehicle // it is not compulsory for abstract class to have abstract method.
                                    // Abstract classes cannot be instantiated they need to be inherited
    {
        public Vehicle() 
        {
            Console.WriteLine("Vehicle constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
        //End of class
    }
    internal class Car: Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()
        {
            //Vehicle tester = new Vehicle();
            Vehicle tester = new Car();
            tester.Start();
        }
    }
}
//object for the parent class will be created first then only the child class will be created
//Cannot create directly objects.