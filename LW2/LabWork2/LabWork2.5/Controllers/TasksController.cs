using Microsoft.AspNetCore.Mvc;

namespace LabWork2._5.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
