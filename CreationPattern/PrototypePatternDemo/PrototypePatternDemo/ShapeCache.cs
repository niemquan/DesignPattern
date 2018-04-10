using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class ShapeCache
    {
        private static Dictionary<string,Shape> shapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            if (string.IsNullOrEmpty(shapeId))
            {
                return null;
            }

            try
            {
                Shape cacheShape = shapeMap[shapeId];
                return (Shape)cacheShape.Clone();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
          
        }

        public static void InitCache()
        {
            Circle circle = new Circle();
            circle.SetId("circle");

            shapeMap.Add(circle.GetId(),circle);

            Square square = new Square();
            square.SetId("square");
            shapeMap.Add(square.GetId(),square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("rectangle");
            shapeMap.Add(rectangle.GetId(),rectangle);
        }
    }
}
