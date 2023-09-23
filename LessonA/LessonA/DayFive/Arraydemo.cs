using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Arraydemo
    {
        class Emp
        {
            private readonly double Id;
            public string Title;
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
            public Emp() { }
            public Emp(double v1)
            {
                Id = v1;
            }
            public double GetID()
            {
                return Id;
            }
        }
        public static void EmpArray()
        {
            Emp[] elist = new Emp[10];
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = new Emp(i);
                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }

            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }

       

        public static void Anagram()
        {
            String str = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered.";
            str = str.Replace(".", "");
            char[] temp1, temp2;
            String str1, str2;
            String[] far = str.Split(" ");

            for (int i = 0; i < far.Count(); i++)
            {
                temp1 = far[i].ToCharArray();
                Array.Sort(temp1);
                str1 = new String(temp1);
                for (int j = 0; j < far.Count(); j++)
                {

                    temp2 = far[j].ToCharArray();//'H''E'
                    Array.Sort(temp2); //[E][H]
                    str2 = new String(temp2); //"eh"
                    if (far[i].Length == far[j].Length) //eh ==eh  // he length is not equal to was
                    {

                        if (str1.Equals(str2) && !far[i].Equals(far[j])) // eh eh != he he 

                        {
                            System.Console.WriteLine(far[i] + " " + far[j]);
                        }

                    }

                }

            }
        }
    } }
