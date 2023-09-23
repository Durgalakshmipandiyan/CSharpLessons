using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{// if the method is abstract then class shoud be abstract
    internal abstract class Book
    {
        public Book()
        {
            Console.WriteLine("Book constructor");
        }
        public abstract void OpenBook();
    }
}
