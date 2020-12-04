using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___Single_Responsibility_Principle.Errado
{
    class Employee
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

        public void RegisterEmployee(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 

            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }
}
