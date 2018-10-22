using System;
using System.Collections.Generic;
using System.Text;

namespace PetSure.ConsoleApp
{
    public class SquareOrRectangleStrategy : ISquareOrRectangleStrategy
    {

        public IShape GetShape(int first, int second, int third, int fourth)
        {
            IShape shape;
            if (first == third && second == fourth)
            {
                if (first == second)
                {
                    shape = new Square();
                }
                else
                {
                    shape = new Rectangle();
                }
            }
            else
            {
                shape = new NullShape();
            }

            return shape;
        }
    }
}
