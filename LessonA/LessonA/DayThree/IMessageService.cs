using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
//no override method. implement interface. Class can inherit mutiple interface.
//class cannot inheritfrom 2 base classes. Multiple implementation is supported
//2 or more methods in multiple classes . child wont be able to provide multiple 

{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
        
    }
    public interface IPayments
    {
        void MakePayment(float amount);
    }
    internal class Whatsapp : IMessageService,IPayments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Method not implemented");
        }
        public void MakePayment(float x)
        {
            Console.WriteLine();
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendAudioMessage(string Message)
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendMessage(string Message)
        {
            Console.WriteLine("Method not implemented");
        }
        //public abstract void SendVideoMessage(string message);
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method not implemented");
        }
    }
    public class ManageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new Whatsapp();
            messageService.SendMessage("hello");
            messageService.ReceiveMessage();

        }

    }
}
