using System;
using System.Collections.Generic;
using System.Text;

namespace PetSure.ConsoleApp
{
    public class Rectangle : IShape
    {
        public Rectangle()
        {
            this.Sides = 4;
            this.Name = "Rectangle";
        }

        public int Sides { get; set; }

        public string Name { get;  set; }
    }
}
