using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method");
        }
    }
}
