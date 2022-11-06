using IS405.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS405.Controllers
{
    public class HomeController : Controller
    {
           
        private EmployeeDbContext _context { get; set; }

        //Constructor
        public HomeController(EmployeeDbContext temp)
        {

            _context = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee e)
        {
            //EmployeeDbContext.Add(e);
            //EmployeeDbContext.SaveChanges();
            // we will need this wherever we have the C in CRUD
            return View(e);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Data(string type)
        {
            
            if (type == null)
            {
                var employeeList1 = _context.Employees.ToList();

                return View(employeeList1);
            }

            if (type == "semester")
            {
                var employeeList2 = _context.Employees.OrderBy(x => x.semester).ToList();

                return View(employeeList2);
            }

            if (type == "supervisor")
            {
                var employeeList3 = _context.Employees.OrderBy(x => x.supervisor).ToList();

                return View(employeeList3);
            }
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Employees()
        {
            ViewBag.Employees = _context.Employees.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Employees(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                _context.SaveChanges();

                return View("Confirmation", emp);            
            }
            else
            {
                ViewBag.Employees = _context.Employees.ToList();

                return View(emp);
            }
        }

        [HttpGet]
        public IActionResult Edit(string byuid)
        {
            ViewBag.Employees = _context.Employees.ToList();

            var emp = _context.Employees.Single(e => e.byuID == byuid);

            return View("Employees", emp);
        }

    }
}
