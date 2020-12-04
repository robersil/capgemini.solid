using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___Open_Closed_Principle
{
    public abstract class Salary
    {
        public abstract void calcSalary(double valor, float tax, double bonus);
    }
}
