using Firstmvcapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security.Policy;

namespace Firstmvcapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoLogin(String txtUser, String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtpwd} ";
            return View();
        }

        public IActionResult SayHello(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                ViewData["v1"] = "name is empty";   //view are dictionary that is they have a key
            }
            else
                 ViewData["v1"] = name;
            return View();
        }
        

     public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["Add result"] = result;
            return View();
        }
        public IActionResult multiply(int x, int y)
        {
            int result = x * y;
            ViewData["mul result"] = result;
            return View("Add");
        }
        public IActionResult divide(int x, int y)
        {
            int result = x / y;
            ViewData["div result"] = result;    //view name and methd name doesnt need to be same
            return View("Add");
        }


        //working with object
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book); //book is passed an object
        }
        
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\bookex.txt";
            string strBook = $"{pBook.BookID} , {pBook.Title}, {pBook.AuthorName} , {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);
        }
        
       
        public IActionResult ListAllBook(int id)
        {
            String fName = @"c:\temp\bookex.txt";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book StringToBook(String[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];   
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;

        }

       public IActionResult AddNewAuthor()
        {
            Author author = new Author();
                return View(author);
        }

        public IActionResult SaveNewAuthor(Author pauthor)
        {
            String fName= @"c:\temp\authordemo.txt";
            String strAuthor = $"{pauthor.AuthorID},{pauthor.AuthorName},{pauthor.Dob},{pauthor.BooksPublished},{pauthor.Royalty}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(pauthor);
        }
        public IActionResult ListAllAuthor(int id)
        {
            String fName = @"c:\temp\authordemo.txt";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];

            author.Dob = DateTime.Parse(data[2]);
            author.BooksPublished= int.Parse(data[3]);
            author.Royalty = data[4];
            return author;

        }
        public IActionResult DeleteAuthor(int id)
        {
            String fName = @"c:\temp\authordemo.txt";
            string[] lines = System.IO.File.ReadAllLines(fName);
            // Create a list to store the updated lines
            List<string> updatedLines = new List<string>();
            // Flag to check if the author with the given ID was found
            bool authorFound = false;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                // Check if the current line has at least 4 parts (AuthorID, AuthorName, DateofBirth, RoyaltyCompany)
                if (data.Length >= 4)
                {
                    int authorID = int.Parse(data[0]);
                    // Check if the AuthorID matches the one to be deleted
                    if (authorID == id)
                    {
                        // Author found, do not add this line to the updated list
                        authorFound = true;
                    }
                    else
                    {
                        // Author not found, add this line to the updated list
                        updatedLines.Add(line);
                    }
                }
            }
            // If the author was not found, you can handle it as needed (e.g., return a message or view)
            if (!authorFound)
            {
                return NotFound(); // Return a 404 response or another appropriate action
            }

            // Write the updated lines back to the text file
            System.IO.File.WriteAllLines(fName, updatedLines);

            // After deleting the author, you can redirect to the ListAllAuthor action to refresh the list
            return RedirectToAction("ListAllAuthor");
        }
        /*public IActionResult EditAuthor()
        {
            // Replace with the path to your file
            String fName = @"c:\temp\authordemo.txt";
            string[] lines = System.IO.File.ReadAllLines(fName);
            // Create a list to store the updated lines
            List<string> updatedLines = new List<string>();
            try
            {
                // Read the file content
                string fileContent = System.IO.File.ReadAllText(fName);

                // Perform your modifications here
                // For example, let's append some text
                fileContent += "\nThis line was added.";

                // Write the modified content back to the file
                System.IO.File.WriteAllText(fName, fileContent);

                ViewBag.Message = "File edited successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }*/
        //for author class  
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}