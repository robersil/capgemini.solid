using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5___Dependency_Inversion_Principle
{
    public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }
}
