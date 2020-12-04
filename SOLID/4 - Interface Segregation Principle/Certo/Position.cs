using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___Interface_Segregation_Principle
{
    public class Position : IRegisterPosition
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public string Description { get; set; }

        public Position()
        {
        }

        public Position(int id, string namePostition, string description)
        {
            Id = id;
            PositionName = namePostition;
            Description = description;
        }

        public void ValideData()
        {
            throw new NotImplementedException();
        }

        public void RegisterBD()
        {
            throw new NotImplementedException();
        }
    }
}
