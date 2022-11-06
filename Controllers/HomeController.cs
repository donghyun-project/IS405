using IS405.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

        public FileResult Export()
        {
                string[] columnNames = new string[] { "byuID", "firstName", "lastName", "international", "gender", "email", "expectedWorkHours", "semester", "year", "phone", "positionType", "classCode", "emplRecord", "supervisor", "hireDate", "payRate", "lastPayIncrease", "payIncreaseAmount", "increaseInputDate", "majorYear", "payGradTuition", "nameChangeCompleted", "notes", "terminated", "terminationDate", "qualtricsSurveySent", "submittedForm", "workAuthorizationReceived", "workAuthorizationEmailSent", "byuName" };
                var emplpoyees_e = _context.Employees.ToList();
                string csv = string.Empty;

                foreach (string columnName in columnNames)
                {
                    csv += columnName + ',';
                }
                csv += "\r\n";

                foreach (var employee in emplpoyees_e)
                {
                    csv += (employee.byuID ?? "").ToString().Replace(",", ";") + ',';
                    csv += (employee.firstName ?? "").Replace(",", ";") + ',';
                    csv += (employee.lastName ?? "").Replace(",", ";") + ',';
                    csv += (employee.international.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.gender ?? "").Replace(",", ";") + ',';
                    csv += (employee.email ?? "").Replace(",", ";") + ',';
                    csv += (employee.expectedWorkHours ?? "").Replace(",", ";") + ',';
                    csv += (employee.semester ?? "").Replace(",", ";") + ',';
                    csv += (employee.year.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.phone ?? "").Replace(",", ";") + ',';
                    csv += (employee.positionType ?? "").Replace(",", ";") + ',';
                    csv += (employee.classCode ?? "").Replace(",", ";") + ',';
                    csv += (employee.emplRecord ?? "").Replace(",", ";") + ',';
                    csv += (employee.supervisor ?? "").Replace(",", ";") + ',';
                    csv += (employee.hireDate ?? "").Replace(",", ";") + ',';
                    csv += (employee.payRate ?? "").Replace(",", ";") + ',';
                    csv += (employee.lastPayIncrease ?? "").Replace(",", ";") + ',';
                    csv += (employee.payIncreaseAmount ?? "").Replace(",", ";") + ',';
                    csv += (employee.increaseInputDate ?? "").Replace(",", ";") + ',';
                    csv += (employee.majorYear ?? "").Replace(",", ";") + ',';
                    csv += (employee.payGradTuition.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.nameChangeCompleted.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.notes ?? "").Replace(",", ";") + ',';
                    csv += (employee.terminated.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.terminationDate ?? "").Replace(",", ";") + ',';
                    csv += (employee.qualtricsSurveySent.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.submittedForm.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.workAuthorizationReceived.ToString() ?? "").Replace(",", ";") + ',';
                    csv += (employee.workAuthorizationEmailSent ?? "").Replace(",", ";") + ',';
                    csv += (employee.byuName ?? "").Replace(",", ";") + ',';

                csv += "\r\n";
                }
                byte[] bytes = Encoding.ASCII.GetBytes(csv);
                return File(bytes, "text/csv", "All_Emp.csv");
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
