using EmployeeMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext context = new EmployeeContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeesView()
        {
            var employee = context.Employees.ToList();
            return View("EmployeesView", employee);
        }
    }
}
