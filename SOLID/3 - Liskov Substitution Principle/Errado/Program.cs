using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___Liskov_Substitution_Principle.Errado
{
    public class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Treinee();
            Console.WriteLine(dev.GetPosition()); //retorna escrito Treinee
        }
    }
}
