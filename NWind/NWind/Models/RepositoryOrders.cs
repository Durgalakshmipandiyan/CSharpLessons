using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace NWind.Models
{
    public class RepositoryOrders
    {
        //from each o if caught select that or leave-linq
        //one order has many details ,when they want to be delivered.
        private readonly NorthwindContext _context;
        public int SelectedId { get; set; }
        public List<SelectListItem> OrderSelectView { get; set; }
        public RepositoryOrders() { }
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }
        public List<int> GetAllOrderId()
        {
            List<int> orderIds = new List<int>();
            foreach (var order in _context.Orders)
            {
                orderIds.Add(order.OrderId);
            }
            return orderIds;
        }
        public List<Order> FindOrderByCustomerID(string customerID)
        {
            return null;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            //to insert child record
            //Order order =_context.Orders.Find(id);
            //return order.OrderDetails.ToList(); 
            //for every single order there are order details
            //using order object we will fetch order based on the object
            List<Order> ordersWithOrderDetails =_context.Orders.Include(d=>d.OrderDetails).ToList();
            Order order=ordersWithOrderDetails.FirstOrDefault(x=>x.OrderId==id);
            return order.OrderDetails.ToList();

        }
        public Product GetProductById(int product)
        {
            return null;
        }
        public List<Order> Orders()
        {
            return _context.Orders.ToList();
        }
    }
}

