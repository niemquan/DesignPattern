using System;

namespace PrototypePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.InitCache();

            Shape cloneCircle = ShapeCache.GetShape("circle");
            if(cloneCircle != null)
            {
                PrintShape(cloneCircle);
            }
            else
            {
                Console.WriteLine("Can't get the shape of circle");
            }


            Shape cloneRectangle = ShapeCache.GetShape("rectangle");

            if (cloneRectangle != null)
            {
                PrintShape(cloneRectangle);
            }
            else
            {
                Console.WriteLine("Can't find the shape of rectangle");
            }

            Shape cloneSquare = ShapeCache.GetShape("square");
            if (cloneSquare != null)
            {
                PrintShape(cloneSquare);
            }
            else
            {
                Console.WriteLine("Can't find the shape of square");
            }

            Console.ReadKey();
        }

        private static void PrintShape(Shape cloneCircle)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Shape: " + cloneCircle.GetType() + ", The Shape Id :" + cloneCircle.GetId());
            cloneCircle.Draw();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
