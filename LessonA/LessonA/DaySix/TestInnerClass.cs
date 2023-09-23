using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LessonA.DaySix
{

        internal class TestEmp
        {
            public static void TestA()
            {
                try
                {
                    Emp1.Address address = new Emp1.Address(null);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                Emp1 e1 = new Emp1();
                //Inner class object
                Emp1.Address add = e1.GetAddress();
                add.Address1 = "Ambattur";
                add.Address2 = "Chennai";
                Console.WriteLine($"Address1:{add.Address1}");
                Console.WriteLine($"Address2:{add.Address2}");
            }
        }


    }

