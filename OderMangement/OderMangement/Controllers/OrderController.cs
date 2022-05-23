using Microsoft.AspNetCore.Mvc;
using OderMangement.Data;
using OderMangement.Models;

namespace OderMangement.Controllers
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
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderList obj)
        {
            if (ModelState.IsValid)
            {
                _db.OrderLists.Add(obj);
                _db.SaveChanges();
                return Redirect("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var oderFromDb = _db.OrderLists.Find(id);
            if(oderFromDb == null)
            {
                return NotFound();
            }
            return View(oderFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderList obj)
        {
            if (ModelState.IsValid)
            {
                _db.OrderLists.Update(obj);
                _db.SaveChanges();
                return Redirect("Index");
            }
            return View();
        }
    }
}
