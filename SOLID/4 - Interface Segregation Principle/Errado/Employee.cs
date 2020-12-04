using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___Interface_Segregation_Principle.Errado
{
    public class Employee : IRegister
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

        public void ValideData()
        {
            throw new NotImplementedException();
        }

        public void RegisterBD()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
