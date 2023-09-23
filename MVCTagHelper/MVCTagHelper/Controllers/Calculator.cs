using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelper.Controllers
{
    public class Calculator : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        public int Add(int x,int y)
        {
            return x+y;
        }
      
    }
}
