using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___Interface_Segregation_Principle
{
    public interface IRegisterEmployee
    {
        void ValideData();
        void RegisterBD();
        void SendEmail();
    }
}
