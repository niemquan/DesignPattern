using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
