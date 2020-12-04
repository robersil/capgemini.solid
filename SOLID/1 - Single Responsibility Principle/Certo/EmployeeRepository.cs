using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___Single_Responsibility_Principle
{
    public class EmployeeRepository
    {
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
