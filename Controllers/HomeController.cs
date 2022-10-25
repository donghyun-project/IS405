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

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Data()
        {
            var employeeList = _context.Employees.ToList();
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }
    }
}
