using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Boxexample
    {
        public static int height;
        public int width;
        public int GetHeight()
        {
            return height;
        }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Boxexample.height = 100;
            Boxexample firstBox = new Boxexample();
            Boxexample secondBox = new Boxexample();
            firstBox.width = 12345;
            secondBox.width = 6789;

          Console.WriteLine($"First Box = {firstBox.width} ,{firstBox.GetHeight()}");
          Console.WriteLine($"Second box ={secondBox.width},{secondBox.GetHeight()}");
          //  Console.WriteLine(Boxexample.type); 
            //Boxtype = "Glass";
            Boxexample.height = 5555;
            Console.WriteLine($"First Box = {firstBox.width} ,{firstBox.GetHeight()}");
            Console.WriteLine($"Second box ={secondBox.width},{secondBox.GetHeight()}");
        }
    }
}
