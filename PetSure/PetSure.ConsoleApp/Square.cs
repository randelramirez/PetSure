using System;
using System.Collections.Generic;
using System.Text;

namespace PetSure.ConsoleApp
{
    public class Square : IShape
    {
        public Square()
        {
            this.Sides = 4;
            this.Name = "Square";
        }

        public int Sides { get; set; }

        public string Name { get; set; }

    }
}
