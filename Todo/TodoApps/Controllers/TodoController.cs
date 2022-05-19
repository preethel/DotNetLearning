using Microsoft.AspNetCore.Mvc;

namespace TodoApps.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
