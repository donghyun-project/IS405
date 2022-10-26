using System;
using System.ComponentModel.DataAnnotations;

namespace IS405.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public string byuID { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool international { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string expectedWorkHours { get; set; }   // Is there a different data type we can use for this
        public string semester { get; set; }
        public int year { get; set; }
        public string phone { get; set; }

        public string positionType { get; set; }
        public string classCode { get; set; }
        public string emplRecord { get; set; }
        public string supervisor { get; set; }
        public string hireDate { get; set; } 
        public string payRate { get; set; }
        public string lastPayIncrease { get; set; }
        public string payIncreaseAmount { get; set; }
        public string increaseInputDate { get; set; }
        public string majorYear { get; set; }
        public bool payGradTuition { get; set; }
        public bool nameChangeCompleted { get; set; }
        public string notes { get; set; }
        public bool terminated { get; set; }
        public string terminationDate { get; set; } 
        public bool qualtricsSurveySent { get; set; } 
        public bool submittedForm { get; set; }          
        public bool workAuthorizationReceived { get; set; }
        public string workAuthorizationEmailSent { get; set; }
        public string byuName { get; set; }

    }
}
