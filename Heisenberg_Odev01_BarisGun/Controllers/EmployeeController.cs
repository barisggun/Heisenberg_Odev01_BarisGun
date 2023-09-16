using Heisenberg_Odev01_BarisGun.Models;
using Heisenberg_Odev01_BarisGun.ValidationRules;
using Microsoft.AspNetCore.Mvc;

namespace Heisenberg_Odev01_BarisGun.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindDbContext context = new NorthwindDbContext();
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View(employees);
        }

        public IActionResult Orders(int id)
        {
            var orders = context.Orders.Where(o => o.EmployeeId == id).ToList();
            var employee = context.Employees.FirstOrDefault(o=> o.EmployeeId == id);

            ViewBag.EmployeeName = $"{employee.FirstName} {employee.LastName}";

            return View(orders);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var validator = new EmployeeValidator();
            var validationResult = validator.Validate(employee);

            if (validationResult.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError("", error.ErrorMessage);
                }
            }
            return View(employee);   
        }
    }
}
