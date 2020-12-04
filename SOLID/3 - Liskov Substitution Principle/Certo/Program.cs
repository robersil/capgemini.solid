using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Certo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Treinee();
            Console.WriteLine(emp.GetPosition());
            emp = new Developer();
            Console.WriteLine(emp.GetPosition());
        }
    }
}
