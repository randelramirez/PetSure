using System;
using System.Collections.Generic;
using System.Text;

namespace PetSure.ConsoleApp
{
    interface ISquareOrRectangleStrategy
    {
        IShape GetShape(int first, int second, int third, int fourth);
    }
}
