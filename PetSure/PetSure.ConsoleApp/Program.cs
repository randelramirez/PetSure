using System;

namespace PetSure.ConsoleApp
{
    /*looks overachitectured, just wanted to use some design patterns(Strategy Pattern)*/
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;

            try
            {
                var sides = GetUserInput();
                ISquareOrRectangleStrategy shapeStrategy = new SquareOrRectangleStrategy();
                var shape = shapeStrategy.GetShape(sides[0], sides[1], sides[2], sides[3]);
                Console.WriteLine(shape.Name);
                
            }
            catch (FormatException)
            {
                // retry logic for invalid user input, perhaps string
                // but will have unhandled exception if errors occur again, added try-catch to for error handling
                // for exercise purposes only
                Console.Clear();
                GetUserInput();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // clear/dispose objects, for demonstraton purpose only
                //Console.Clear();
                Console.ReadKey();
            }

        }

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = (Exception)e.ExceptionObject;
            Console.WriteLine(exception);
            Console.ReadKey();

        }

        private static int[] GetUserInput()
        {
            int[] sideLengths = new int[4];
            for (int sideNumber = 0; sideNumber < 4; ++sideNumber)
            {
                Console.Write($"Input {sideNumber + 1}: ");
                sideLengths[sideNumber] = int.Parse(Console.ReadLine());
            }
            return sideLengths;
        }
    }
}
