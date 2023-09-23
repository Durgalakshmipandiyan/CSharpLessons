using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day1
{
    internal class Statement
    {
        public static void Testone()
        {
            Console.WriteLine("Enter age : ");
            String age = Console.ReadLine();
            int ageval = int.Parse(age);
            if(ageval<18)
            {
                Console.WriteLine("sorry! u cant drive");
            }
            else
            {
                Console.WriteLine("u can drive");
            }
        }

        public static bool IsNumeric(String pValue)
        {
            bool result = false;
            if (pValue == null)
            {
                Console.WriteLine("INVALID String!!! Value is NULL....");
                return false;
            }
            char[] data = pValue.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not a NUMBER!!!");
                    return false;
                }
            }
            result = true;
            return result;
        }
    }
}
