using Microsoft.AspNetCore.Mvc;
using TodoApps.Data;
using TodoApps.Models;

namespace TodoApps.Controllers
{
    public class TodoController : Controller
    {
        private readonly AppDbContext _db;
        public TodoController(AppDbContext db)
        {
            _db = db;
               
        }
        public IActionResult Index()
        {
            IEnumerable<TodoList> todoLists = _db.TodoLists;  
            return View(todoLists);
        }
        public IActionResult Create()
        {
           return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TodoList obj)
        {
            _db.TodoLists.Add(obj);
            _db.SaveChanges();
            return Redirect("Index");
        }
    }
}
