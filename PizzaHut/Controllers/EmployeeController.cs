using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaHut.Models;

namespace PizzaHut.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                   ID = 1, FirstName = "Jocko", LastName = "Willink", Title = "Navy Seal", HireDate = new DateTime(2017, 1, 18), City = "Oklahoma"
                },
                new Employee()
                {
                   ID = 2, FirstName = "Mike", LastName = "Tyson", Title = "Professional Boxer", HireDate = new DateTime(2014, 3, 14), City = "Catskill NY"
                },
                new Employee()
                {
                   ID = 3, FirstName = "Fyodor", LastName = "Dostoevsky", Title = "Novelist", HireDate = new DateTime(1910, 8, 19), City = "Moscow"
                }
            };
        [Route("Employee/Index")]
        public IActionResult Index()
        {
            var model = employees;
            return View(model);
        }
        [Route("Employee/Details")]
        public IActionResult Details(int id)
        {
            var employee = employees.FirstOrDefault(p => p.ID == id);
            return View(employee);
            
        }
        [Route("Employee/Create")]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee e)
        {
            employees.Add(e);
            return RedirectToAction("Index");
        }
    }
}