using System;
using System.Collections.Generic;
using System.Text;

namespace PetSure.ConsoleApp
{
    public class NullShape : IShape
    {
        public NullShape()
        {
            this.Name = "Null shape";
        }

        public int Sides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
    }
}
