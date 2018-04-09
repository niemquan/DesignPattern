using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 20.5f;
        }
    }
}
