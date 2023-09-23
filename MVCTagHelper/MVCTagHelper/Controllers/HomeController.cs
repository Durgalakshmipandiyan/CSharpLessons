using Microsoft.AspNetCore.Mvc;
using MVCTagHelper.Models;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace MVCTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Cannot have same method or actions . the index will throw error
        // but if we add httppost to it it wont throw error

        [HttpPost]
        public IActionResult Index(int x, IFormCollection collection)
        {
            StringBuilder data = new StringBuilder(500);
            data.Append("x:");
            data.Append(x);
            data.Append(" ");
            data.Append("name:");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password");
            data.Append(collection["password"]);
            //foreach (var item in collection)
            //{ it is cmment coz it shows all the collection that might arise the error
            //    data.Append(item.Key);
            //    data.Append(": ");
            //    data.Append(item.Value);
            //    data.Append(" ");
            //}
            ViewData["x"] = data.ToString(); //limited to the view and controller of that view
            //TempData["globalx"] = x; // global and can be accessed by other controllers
            return View("IndexPost");
        }
        public ActionResult DoTask(int? id) //in the runtime type /Home/DoTask/12 this will return 12
        {
            //in the runtime type /Home/DoTask this will return null and set default as 0
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View("DoTask");
        }
        public ActionResult Test()
        {
            //action cannot be called within an action it will be redirected
            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            Book b1 = new Book()
            {
                AuthorName = "HLee"
            };

            ViewData["book"] = b1;
            return View();
        }
        [ResponseCache(Duration =15)] //for the 15 sec it wont show any results
        //only for certain location
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
            return View();
        }
       
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Menu()
        {
            String conString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information,conString); //logger will write in a file
            //LogLevel is the enum and info is the constants
//output in the console
            return View();
        }
        public ActionResult Echo(String name, String City)
        {
            String s1 = "user" + name + "from City=" + City;
            ViewData.Add("Data1", s1);
            return View();
        }

        public ActionResult SayHello(String name)
        {
            //Home/SayHello?name=Alex
            String s1 = ("Hello" + name);
            ViewData.Add("Data1", s1);
            return View("Echo");
        }
    }
}