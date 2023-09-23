using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{ 
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;

        public Box(int x)//Parent have parameter but child expect them to not have
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height}, Length:{Length}, Width: { Width}";
        }
    }
    internal class WoodenBox : Box
    {
        public int Area;
        public WoodenBox() : base(1)
        {
            Console.WriteLine( "Wooden box constructor");
        }
        public WoodenBox(int x) : base(x) // we can either give x or any values 100,10
        {
            Console.WriteLine("Wooden box constructor");
        }
        public WoodenBox(int x, int y): base(x) // parent class only have one parameter so either base x or base y
        {
            Console.WriteLine("Wooden box constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden box shifted");
        }
        public override string ToString()
        {
            return "Elsa and aiden";
        }
    }
   
    // every child expects the parent to have parameterless constructor. so we should call explicitly
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(100);
            box.Height = 10;
            box.Length = 20;
            box.Width = 5;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
        }

        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 100;
            box.Move();

        }
        
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
           // box.Area = 100; these are not working coz parent cant inherit properties of child
            //box.Move();

        }
    }
}
