using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bootle";
        }
    }
}
