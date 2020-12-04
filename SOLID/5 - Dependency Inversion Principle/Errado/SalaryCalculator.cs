using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___Dependency_Inversion_Principle.Errado
{
    public class SalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }
}
