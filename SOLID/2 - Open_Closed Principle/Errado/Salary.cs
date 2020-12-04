using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___Open_Closed_Principle.Errado
{
    public class Salary
    {
        public enum Position { Designer, Developer }
        public void calcSalary(double valor, float tax, double bonus, Position positionName)
        {
            if(positionName == Position.Designer)
            {

            }

            if(positionName == Position.Developer)
            {

            }
        }
    }
}
