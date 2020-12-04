using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___Dependency_Inversion_Principle
{
    public class SalaryCalculatorModified : ISalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }
}
