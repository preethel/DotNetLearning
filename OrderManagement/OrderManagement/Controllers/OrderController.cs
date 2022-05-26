using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Models;

namespace OrderManagement.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext _context;
        public OrderController(OrderDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<OrderCategory> categories = _context.OrderCategories;
            return View(categories);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderCategory obj)
        {
            if (ModelState.IsValid)
            {
                _context.OrderCategories.Add(obj);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var OderfromDb = _context.OrderCategories.Find(id);
            if(OderfromDb == null)
            {
                return NotFound();
            }
            return View(OderfromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderCategory obj)
        {
            if (ModelState.IsValid)
            {
                _context.OrderCategories.Update(obj);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View();
        }
    }
}
