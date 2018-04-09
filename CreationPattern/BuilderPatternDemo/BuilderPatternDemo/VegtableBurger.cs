using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class VegtableBurger : Burger
    {
        public override string Name()
        {
            return "Vegtable Burger";
        }

        public override float Price()
        {
            return 10.5f;
        }
    }
}
