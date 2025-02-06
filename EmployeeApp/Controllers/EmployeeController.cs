using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        // In-memory employee list
        private static List<Employee> employees = new List<Employee>
        {
            new Employee("Sam", "Billings", "Manager", 75000),
            new Employee("Steve", "Smith", "Developer", 65000),
            new Employee("Shane", "Warne", "Designer", 60000),
            new Employee("Mitchell", "Starc", "Tester", 55000),
            new Employee("Shane", "Watson", "HR", 50000)
        };

        private static int currentIndex = 0; // For browsing employees

        public IActionResult Index()
        {
            return View(employees[currentIndex]);
        }

        public IActionResult Next()
        {
            currentIndex = (currentIndex + 1) % employees.Count;
            return RedirectToAction("Index");
        }

        public IActionResult Previous()
        {
            currentIndex = (currentIndex - 1 + employees.Count) % employees.Count;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(new Employee(employee.FirstName, employee.LastName, employee.JobTitle, employee.Salary));
            return RedirectToAction("Index");
        }
    }
}
