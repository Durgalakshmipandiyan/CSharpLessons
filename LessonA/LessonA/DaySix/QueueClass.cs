using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    //objects with Icloneable interfaces can be cloned. create a new object that is the copy of the current instance.
    //ex: color of tag is used to diff the visitor and the employee of the gavs. 
    //tag is usde to for the environment . which is marker -- not for changing any behaviourbut to be known by
    //other methods.SERIALIZATION - transforming object from one place to other. Ex: u wont be able to save. ie 
    //the process of breaking an object into small pieces. after serialzing they will be deserialized. 
    //RPC . check obj is Iserializable it can be serialized.interfaces that is empty is called null interface.
    //Null interface can only be markers that doesnt mean all markers are null. Serializable and cloneable are markers.
    
    //
    internal class QueueClass
    {
        //Peek picks the object without removing the obj from the queue
        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue(25);
            Console.Write(25 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
                Console.Write(x+" ");
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }  
    
    public static void StackDemoA()
    {
        Stack st = new Stack();
        Random r = new Random();
        int x = 0;
        st.Push(25);
        for (int i = 0; i < 10; i++)
        {
            x = r.Next(100);
            st.Push(x);
        }
        Console.WriteLine("");
        int count = st.Count;
        Console.WriteLine("Count=" + count);
        for (int i = 0; i < count; i++)
        {
            Console.Write(st.Peek() + " ");
            // Peek reads the first object in the queue 
            // without removing the object
        }

        Console.WriteLine("");
        count = st.Count;
        Console.WriteLine("Count After Peek =" + count);
        Console.WriteLine("Contains 25-" + st.Contains(25));
        for (int i = 0; i < 5; i++)
        {
            Console.Write(st.Pop() + " ");
        }
        Console.WriteLine();
        count = st.Count;
        Console.WriteLine("Count After Pop=" + count);
    }
        //hash table 

        public static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);
            ht.Add("id", 123);
            ht.Add("name", "Gates");
            Console.WriteLine("Count " + ht.Count);
            ht.Add("sal", 15000);
            ht.Add("r1", new Random().Next());
            ht.Add("IsDirector", false);
            ht.Add("Address", null);
            // ht.Add("name", "Bill");// Runtime Error duplicate key 
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine(ht["sal"]);
            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("r1"));
            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));



            foreach (object k in ht.Keys)
                Console.WriteLine(k + "--" + ht[k]);
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }

        //sorted list is a dictionary. 
  public static void EmpDictionaryDemo()

        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }

            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);

            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }
    }
}
