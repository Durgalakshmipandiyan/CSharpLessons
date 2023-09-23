using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NWind.Models;
using static NWind.Models.RepositoryOrders;

namespace NWind.Controllers
{
    public class OrderController : Controller
    {
        private  RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders orders)
        {
            _repositoryOrders = orders;   
        }
        // GET: OrderController
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);
            return View(idsViewModel);
        }

        // GET: OrderController/Details/5
        [HttpPost]
        public ActionResult Details(int id)
        {
            Order order=_repositoryOrders.FindOrderById(id); //need to have all the details in the db 
            List<OrderDetail> detail = _repositoryOrders.FindOrderDetailByOrderId(id);
            //connection on demand object is created. count is 0
            ViewData["OrderDetail"] = detail;
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
