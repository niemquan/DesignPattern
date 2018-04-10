using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Reactangle::Draw() method");
        }
    }
}
