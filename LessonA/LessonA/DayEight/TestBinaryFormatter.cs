using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayEight
{
    public class TestBinaryFormatter
    {
        public static void SerializeCustomer()
        {
            Customer obj = new Customer(1001);
            obj.FirstName = "Venkat";
            obj.LastName = "Krishnan";
            obj.MiddleName = "B";
            obj.CreditLimit = "200000";
            Console.WriteLine("Before serialization");
            obj.ToString();
            Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            //Opens a file and serializes the object into it in binary format.
            using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Create))  //Filemode is a enum
                //deserialization is it restores even the private files
                //object serialization whatever inside the object the data is saved that is encapsulation ie both private and public
                // when u just read the private values wont be saved
            //using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                formatter.Serialize(stream, obj);
            }
            Console.WriteLine("Completed.....");
        }

        public static void DeSerializeCustomer()
        {
            using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                Customer obj = null;
                formatter = new BinaryFormatter();
                obj = (Customer)formatter.Deserialize(stream);
                Console.WriteLine("After deserialization the object contains: ");
                Console.WriteLine(obj.ToString());
                Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            }
        }
    }
}
