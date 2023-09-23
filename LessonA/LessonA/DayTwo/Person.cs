using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LessonA.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; }



        public override string ToString()
        {
            return $"ID: {this.Id},Name:{Title} {FirstName} {LastName},\n" +
                $"Address:  {Address},City: {City}, Region: {Region}\n " +
                $"Phone :{Phone},Country: {Country}, Zip: {PostalCode} ";
        }



    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            Person person = new Person();
            person.Id = 1;
            person.FirstName = "Preethi";
            person.LastName = "Srinivasan";
            person.Address = "Omalur";
            person.City = "Salem";
            person.Region = "Salem";
            person.PostalCode = "12345";
            person.Country = "India";
            person.Phone = "3788912122";
            person.Title = "Ms. ";
            String data = person.ToString();
            Console.WriteLine(data);
        }
    }
}