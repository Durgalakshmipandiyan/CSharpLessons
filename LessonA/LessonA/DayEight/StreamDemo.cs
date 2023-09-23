using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayEight
{
    internal class StreamDemo
    {
        //char streams
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key followed by enter");
            int x = Console.Read(); //read is a input stream --read only reads one character -readline to read stream of characters
            ch = (char)x; // get a char
            Console.WriteLine("/n" + x + "Your key is" + ch); // write output stream
            //text reader is a abstract class and char stream
        }
        public static void TestTwo()
        {
            char ch= ' ';
            Console.WriteLine("Press a key q to exit");
            while(ch !='q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is:" + ch);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence"); //any operation with null will be null
            string? str = Console .ReadLine(); //value type cannot be null . in a table column type is numeric the vlue can be null
            Console.Out.WriteLine(" " + str); //if string '?' it is called nullable where they can be set to null
        }
        public static void TestNullableTypes()
        {
            int? x = 0;
            x = null;
            //if there is null then they will return the default value of that data type
            if(x.HasValue)
            {
                Console.WriteLine( x.Value);
            }
            else
            {
                Console.WriteLine( x.GetValueOrDefault());
            }
        }
    }
}
