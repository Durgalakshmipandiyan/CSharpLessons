using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    internal class CollectionClass
    {
        public static void SetStringDemo()
        {
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add(null);
            stringSet.Add(null);
            //Console.WriteLine($"Count:{stringSet.Count}");
            Console.WriteLine($"Count" + stringSet.Count);
            //int count= stringSet.Count;
            //Console.WriteLine("count"+count);
           // Console.WriteLine();
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }
        }

        public static void TestGenericSortedSetInt()
        {
            SortedSet<int> alist = new SortedSet<int>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add(10);
            alist.Add(10);
            alist.Add(10);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                alist.Add(x);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (int i in alist)
                Console.Write(i + ",");
        }

        //performance will be slower for sorted string 
        public static void TestGenericSortedSetString()
        {
            SortedSet<string> alist = new SortedSet<string>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Hello");
            alist.Add("Ashley");
            alist.Add("Gavs");
            alist.Add("Gavs");
            alist.Add("Infy");
            alist.Add("CTS");
            alist.Add("TCS");
            alist.Add("Adyar");
            alist.Add("Banglore");
            alist.Add("Pune");
            alist.Add("Goa");
            alist.Add("Zif");
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (string i in alist) Console.Write(i + ",");
        }
        //sorted list have key and a value
  public static void TestSortedListA()

        {

            SortedList<int, int> slist = new SortedList<int, int>(); //<int><int> key and a value
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
             
                if (!slist.ContainsKey(x))
                    slist.Add(x, i * x); //sorting is based on key . key is in ascending order. hashcode is based on the string
                Console.Write(x + " ");

            }

            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + "," + i.Value);
            }
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>(); //int key , emp value
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() { ID = r1.Next(100), Name = "Ellango", Salary = r1.NextDouble() * 5000 };
            Emp e5 = new Emp() { ID = r1.Next(100), Name = "Basker", Salary = r1.NextDouble() * 5000 };
            if (!empsortlist.ContainsKey(e1.ID))
                empsortlist.Add(e1.ID, e1);
            if (!empsortlist.ContainsKey(e2.ID))
                empsortlist.Add(e2.ID, e2);
            if (!empsortlist.ContainsKey(e3.ID))
                empsortlist.Add(e3.ID, e3);
            if (!empsortlist.ContainsKey(e4.ID))
                empsortlist.Add(e4.ID, e4);
            if (!empsortlist.ContainsKey(e5.ID))
                empsortlist.Add(e5.ID, e5);

            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);

            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var orderedlist = empsortlist.OrderBy(tkey => tkey.Value.Name); //tkey is not compulsory it can be anything. lyk a , b, c.It is a variable
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Name);//.value will be obj and .name will be field
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
        }

    }
}
