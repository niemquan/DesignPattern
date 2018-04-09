using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 3.5f;
        }
    }
}
