using System;
using Microsoft.EntityFrameworkCore;

namespace IS405.Models
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Employee>().HasData(
                new Employee
                {
                    firstName = "Mickey",
                    lastName = "Mouse",
                    international = false,
                    gender = "Male",
                    email = "mmouse@gmail.com",
                    expectedWorkHours = "8-5",
                    semester = "Winter",
                    year = 2023,
                    phone = "801-123-4567",
                    byuID = "11-222-1234",
                    positionType = "TA",
                    classCode = "IS-201",
                    //emplRecord leaving null
                    supervisor = "Hilton",
                    hireDate = "08-12-2022",
                    //lastPayIncrease, payIncreaseAmount, increaseInputDate,  major year,
                    // payGradTuition, nameChangeCompleted, notes, terminated, terminationDate, qualtricsSurveySent
                    // submittedForm, workAuthorizationReceived, workAuthorizationEmailSent leaving null
                    byuName = "Mickey Mouse"
                }
                );
        }
    }
}
