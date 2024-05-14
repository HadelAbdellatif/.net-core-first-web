using Microsoft.AspNetCore.Mvc;
using Task_1.Data;

namespace Task_1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var emp = context.Employees.ToList();
            return View("Index", emp);
        }
    }
}
