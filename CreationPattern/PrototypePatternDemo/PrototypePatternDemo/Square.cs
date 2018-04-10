using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
