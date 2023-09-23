using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelper.Controllers
{
    public class TagHelper : Controller
    {
        // GET: TagHelper
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabs() 
        {
            ViewData["data1"] = "Tom and jerry are good friends";
            return View();
        }
    }
}
