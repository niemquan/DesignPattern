using System;
using System.Collections.Generic;
using System.Text;using BuilderPatternDemo;

namespace BuilderPatternDemo
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 3.5f;
        }
    }
}
