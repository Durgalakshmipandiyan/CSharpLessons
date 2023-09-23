using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LessonA.DayTwo
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
       
        public string Publisher { get; set; } = string.Empty;
        
        public string Director { get; set; } = string.Empty;
        public string AuthorLocation { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Pages { get; set; }
        public float Rating { get; set; }


        public override string ToString()
        {
            return $"ID: {this.Id},\n Name:{Name},\n" +
                $"AuthorName:  {AuthorName},\n Publisher: {Publisher}, \n " +
                $"AuthorLocation :{AuthorLocation} ,\n Year :{Year} ,\n NumberOfPages :{Pages},\n Rating : {Rating} " ;
        }



    }
    internal class TestBook
        
    {
        public static void TestOne()
        {
            Book  book = new Book();
            book.Id = 1;
            book.Name = "Elite";
            book.AuthorName = "Elsa";
            book.Publisher = "Rohan";
            book.AuthorLocation = "France";
            book.Year = 2019;
            book.Pages = 437;
            book.Rating = 4.9f;
            String data = book.ToString();
            Console.WriteLine(data);
        }
    }
}