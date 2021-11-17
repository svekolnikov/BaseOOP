using System;
using System.Drawing;

namespace BasicsOOP.Geometry
{
    internal class Point : Figure
    {
        public override string Name => "Point";
        public Point(float x, float y, bool isVisible, Color color) 
            : base(x, y, isVisible, color)
        {}

        public virtual void Print()
        {
            base.Print();
        }
    }
}
