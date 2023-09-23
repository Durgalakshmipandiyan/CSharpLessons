using LessonA.Day1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySeven
{
    internal class ThreadDemo
    {
        //additional threads for garbage collection and just time compiler 
        //Thread contains culture - localization and gloabalization
        //Want output in different that is in africa like that
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine( "CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine( DateTime.Now .ToLongDateString ());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");

        }
        //Stopped thread cannot be restarted. Single thread is spilt into multi thread is called --fork.
        //The application will end only when all the thread is completed
        public static void DemoA()  //multi thread output is used (1 and 9 which cn be run multiple times)
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB() // single thread which is similar to primary key.assigned id will be not used by other
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA(); // we are not directly initializing a1.service instead using thread
            Thread t2 = new Thread(a1.DoTaskA); //delegate
            t2.Start();
            a1.DoTaskA();
            //One thread will work another will sleep . x is a local variable .value of x is incremented
            // each thread gets its own copy of x
            // when 2 or more threads occur concurrently Local variable are thread safe by default we dont need sync nd lock
            //Each thread has own stack. Thread is shared by heap(1 heap only)
            //Global variables are not thread safe .. 2 or more access then they end up overwriting each others data

            Console.WriteLine("---------End of DemoB-----------");

            //If i need global and multi thread then ticket booking system 
            //Release locks inside a finally 
        }
        public static void DemoB2() // single thread which is similar to primary key.assigned id will be not used by other
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA(); // we are not directly initializing a1.service instead using thread
            Thread t2 = new Thread(a1.DoTaskA); //delegate
            Console.WriteLine (t2.ManagedThreadId + "T1State"+ t1.ThreadState) ;
            t2.Start();
            Console.WriteLine(t2.ManagedThreadId + "state after start" + t1.ThreadState);
            Thread.Sleep(6000);
            Console.WriteLine(t2.ManagedThreadId + "T1 state after sleep" + t1.ThreadState);
            Console.WriteLine("---------End of DemoB-----------");
        }

        
        
            public static void DemoC() //technically three threads are running
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine( "MainThread ID"+id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start(); 
            t2.Start();
            Console.WriteLine("---------End of DemoC-----------");
        }

            public static void DemoD() //technically three threads are running
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine( "MainThread ID"+id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start(); 
            t2.Start();
            t1.Join(7000);
            if(t1.IsAlive)t1.Abort();
            t2.Join(7000);
            if(t2.IsAlive)t2.Abort();
            //executes 1st if join is not included.
            //if they dont finish in 7000 then they will be forcefully aborted
            Console.WriteLine("---------End of DemoD-----------");
            //dont use abort it was removed
        }
            
  }
}
