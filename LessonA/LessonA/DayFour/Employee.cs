using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFour
{
    public enum City { Chennai, Bangalore, Goa };
    public enum Designation { Manager, Admin, Developer };
    internal class Employee
    {
        public readonly int Id; //read only variables are created only through the constructor of the class 
        //which are unique ex:public
        public string EName  = string.Empty;
        public City ECity; //public string Ecity
        public Designation JobTitle; //public string JobTitle
        public Employee(int v1)
        {
            Id = v1;
        }
        public override string ToString()
        {
            {
                //Console.WriteLine("Details of employee:");
                //Console.WriteLine( "ID" =Id+ "Name" + EName);
                //Console.WriteLine( ECity);
                //Console.WriteLine( JobTitle);
                String output = String.Empty;
                output = $"Details of the employee are: {Id} {EName} {ECity} {JobTitle}";
                return output ;
            }
        }

       
        //Enum where one of the particular constants will be used.that is to provide only particular options
    }
    class TestEmployee
    {
        public static void TestOne()
        {
            Employee emp = new Employee(2);
            emp.EName = "Rhys Larsen";
            emp.ECity = City.Chennai;
            emp.JobTitle = Designation.Developer;
            String output = emp.ToString();
            Console.WriteLine( output);

        }
    }
}

