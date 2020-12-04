using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Errado
{
    class Treinee : Developer
    {
        public override string GetPosition()
        {
            return "Treinee position";
        }
    }
}
