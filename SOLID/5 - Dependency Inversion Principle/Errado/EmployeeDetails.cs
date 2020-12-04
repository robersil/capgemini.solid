using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___Dependency_Inversion_Principle.Errado
{
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public float GetSalary()
        {
            var salaryCalculator = new  SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
