using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDemo
{
    public interface IItem
    {
        string Name();

        IPacking Packing();

        float Price();
    }
}
