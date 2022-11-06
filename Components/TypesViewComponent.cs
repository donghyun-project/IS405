using IS405.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS405.Components
{
    public class TypesViewComponent:ViewComponent
    {
        private EmployeeDbContext _context { get; set; }
        public TypesViewComponent(EmployeeDbContext temp)
        {
            _context = temp;
        }
        public IViewComponentResult Invoke()
        {
            //var types = _context.Employees.Select(x = )
            return View();
        }
    }

}
