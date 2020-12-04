using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___Single_Responsibility_Principle
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Employee()
        {                
        }

        public Employee(int id, string name, string lastName, string position)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Position = position;
        }
    }
}
