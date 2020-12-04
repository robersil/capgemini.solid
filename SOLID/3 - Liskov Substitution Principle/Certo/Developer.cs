using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Certo
{
    public class Developer : Employee
    {
        public override string GetPosition()
        {
            return "Developer position";
        }
    }
}
