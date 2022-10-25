using System;
using Microsoft.EntityFrameworkCore;

namespace IS405.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base (options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
