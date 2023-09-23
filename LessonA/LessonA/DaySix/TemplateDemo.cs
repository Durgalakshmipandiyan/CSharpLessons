 using LessonA.DayFour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class TemplateDemo
    { // Hash code is a single unique number. which will be provided by the runtime.

        public static void TestOne()
        {

            Object objectOne = new object(); 
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");
            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Rhys"; //object hash code has to be the same
            Emp empTwo = empOne; //new Emp();
            empTwo.ID = 1001; empTwo.Name = "Rhys";
            Emp empThree = empOne;//new Emp();
            empOne.ID = 1001; empThree.Name = "Rhys";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());
        }

        //understanding generics
        // there is abox and a list of numbers and nothing else
        //data type not defined T is a template where T can be boolean, string, int
        //One box can have integers and another can have strings 
        class BoxExample
        {
            List<int> noList = new List<int>();
            public void FillList(int from, int to)
            {
                int i = 0;
                for (i = from; i < to; i++)
                {
                    noList.Add(i);
                }
            }
            public List<int> GetList()
            {
                return noList;
            }
        }

        class BoxA<T>
        {
            List<T> myList = new List<T>();
            public void FillList(T data)
            {
                myList.Add(data);
            }
            public List<T> GetList()
            {
                return myList;
            }
        }

        //by ref Parameters
        public static void ByRefMethod(int v1, ref int v2)
        {
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//5, 10
            v1 = v1 + 100;
            v2 = v1 * 2000;
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//105, 210000 
        }
        public static void TestByRefMethod()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 10
            ByRefMethod(x, ref y);
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 210000
        }
        //what if a method should have 2 or more return value with diff data types? use out keyword--write only 
        //nd not read  . ref is in out parameters.purpose - to return diff data types or else we will use array itself
        
        //out parameter -- insert add 
        public static void OutParameterMethod(int v1, out int v2)
        {
            //Console.WriteLine("v1={0},v2={1}", v1, v2); out v2 is unassigned
            v1 = v1 + 100;
            //v2 = v2 * 2000; //out v2 is unassigned
            v2 = v1 * 5; // v2 (y) is assigned
            Console.WriteLine("\t M2==> v1={0},v2={1}", v1, v2);
        }
        public static void TestOutParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before M2==> x={0},y={1}", x, y); // 5, 10
            OutParameterMethod(x, out y);
            //M2(v2: out x, v1: y);//Using Named Arguments
            Console.WriteLine("After M2==> x={0},y={1}", x, y);// 5, 525
        }
        public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x={x},y={y}");
            OptionalParameters();
            OptionalParameters(x, y);
            OptionalParameters(v2: x, v1: y);//Using Named Arguments
        }
        //actual parameter is array but they are independent in params that is the purpose//params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }

        //creating inner classes


    }
}

