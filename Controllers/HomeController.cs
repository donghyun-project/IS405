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

        public IActionResult Data()
        {
            var employeeList = _context.Employees.ToList();
            return View(employeeList);
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

        //edit
        [HttpGet]
        public IActionResult Edit(string byuid)
        {
            ViewBag.Employees = _context.Employees.ToList();

            var emp = _context.Employees.Single(e => e.byuID == byuid);

            return View("Employees", emp);
        }

        [HttpPost]
        public IActionResult Edit (Employee emp)
        {
            _context.Update(emp);
            _context.SaveChanges();

            return RedirectToAction("Data");
        }

        //delete
        [HttpGet]
        public IActionResult Delete (string byuid)
        {
            var emp = _context.Employees.Single(e => e.byuID == byuid);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Delete(Employee emp)
        {
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Data");
        }

    }
}
