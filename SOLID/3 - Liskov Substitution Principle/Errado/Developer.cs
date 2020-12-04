using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Errado
{
    public class Developer
    {
        public virtual string GetPosition()
        {
            return "Developer position";
        }
    }
}
