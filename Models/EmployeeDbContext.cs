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
                    hireDate = "08-10-2022",
                    //lastPayIncrease, payIncreaseAmount, increaseInputDate,  major year,
                    // payGradTuition, nameChangeCompleted, notes, terminated, terminationDate, qualtricsSurveySent
                    // submittedForm, workAuthorizationReceived, workAuthorizationEmailSent leaving null
                    byuName = "Mickey Mouse"
                },

                new Employee
                {
                    firstName = "Walter",
                    lastName = "White",
                    international = false,
                    gender = "Male",
                    email = "heisenberg@gmail.com",
                    expectedWorkHours = "8-5",
                    semester = "Fall",
                    year = 2021,
                    phone = "425-555-7711",
                    byuID = "89-161-7523",
                    positionType = "TA",
                    classCode = "IS-413",
                    //emplRecord leaving null
                    supervisor = "Hilton",
                    hireDate = "05-17-2021",
                    //lastPayIncrease, payIncreaseAmount, increaseInputDate,  major year,
                    // payGradTuition, nameChangeCompleted, notes, qualtricsSurveySent
                    // submittedForm, workAuthorizationReceived, workAuthorizationEmailSent leaving null
                    terminated = true,
                    terminationDate = "12-17-2021",
                    byuName = "Walter White"
                },
                new Employee
                {
                    firstName = "Elenor",
                    lastName = "Shellstrop",
                    international = false,
                    gender = "Female",
                    email = "badplace@gmail.com",
                    expectedWorkHours = "12-4",
                    semester = "Spring",
                    year = 2020,
                    phone = "413-887-9145",
                    byuID = "45-233-1110",
                    positionType = "TA",
                    classCode = "IS-115",
                    //emplRecord leaving null
                    supervisor = "Burton",
                    hireDate = "01-10-2020",
                    // major year,
                    // payGradTuition, nameChangeCompleted, notes, terminated, terminationDate, qualtricsSurveySent
                    // submittedForm, workAuthorizationReceived, workAuthorizationEmailSent leaving null
                    lastPayIncrease = "05-01-2020",
                    payIncreaseAmount = "$0.67",
                    increaseInputDate = "04-29-2020",
                    byuName = "Elenor Shellstrop"
                },
                new Employee
                {
                    firstName = "Elena",
                    lastName = "Gilbert",
                    international = false,
                    gender = "Female",
                    email = "vampiresrules@gmail.com",
                    expectedWorkHours = "7-11",
                    semester = "Fall",
                    year = 2020,
                    phone = "685-773-6592",
                    byuID = "22-355-8870",
                    positionType = "RA",
                    classCode = "IS-403",
                    //emplRecord leaving null
                    supervisor = "Anderson",
                    hireDate = "07-31-2021",
                    //lastPayIncrease, payIncreaseAmount, increaseInputDate,  major year,
                    // payGradTuition, nameChangeCompleted, notes, terminated, terminationDate, qualtricsSurveySent
                    // submittedForm, workAuthorizationReceived, workAuthorizationEmailSent leaving null
                    byuName = "Elena Gilbert"
                }
                );
        }
    }
}
