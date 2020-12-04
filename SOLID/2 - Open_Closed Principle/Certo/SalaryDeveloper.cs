using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___Open_Closed_Principle
{
    public class SalaryDeveloper : Salary
    {
        public override void calcSalary(double valor, float tax, double bonus)
        {
            throw new NotImplementedException();
        }
    }
}
