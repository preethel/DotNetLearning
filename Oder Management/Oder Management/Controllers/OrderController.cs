using Microsoft.AspNetCore.Mvc;
using Oder_Management.Data;
using Oder_Management.Models;

namespace Oder_Management.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext _db;
        public OrderController(OrderDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<OrderList> objOderList = _db.OrderLists;
            return View(objOderList);
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}
