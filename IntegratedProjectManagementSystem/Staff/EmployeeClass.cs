using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedProjectManagementSystem.Staff
{
    public class EmployeeClass
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal DailyRate { get; set; }

        public string Position { get; set; }

        public string Status { get; set; }   // <-- REQUIRED

        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public byte[] EmployeePhoto { get; set; }


        // Utility methods

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsActiveStatus()
        {
            return IsActive;
        }

        public decimal CalculateSalary(decimal hoursWorked)
        {
            decimal hourlyRate = DailyRate / 8;
            return hourlyRate * hoursWorked;
        }
    }
}

