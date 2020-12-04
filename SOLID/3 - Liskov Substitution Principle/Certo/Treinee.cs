using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Certo
{
    public class Treinee : Employee
    {
        public override string GetPosition()
        {
            return "Treinee position";
        }
    }
}
