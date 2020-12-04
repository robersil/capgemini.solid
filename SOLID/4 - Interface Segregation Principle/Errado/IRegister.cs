using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___Interface_Segregation_Principle.Errado
{
    public interface IRegister
    {
        void ValideData();
        void RegisterBD();
        void SendEmail();
    }
}
