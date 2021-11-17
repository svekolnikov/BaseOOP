using System;
using System.Drawing;

namespace BasicsOOP.Geometry
{
    internal class Rectangle : Point
    {
        public float A { get; }
        public float B { get; }

        public Rectangle(float x, float y, bool isVisible, Color color, float a, float b) 
            : base(x, y, isVisible, color)
        {
            A = a;
            B = b;
            Name = "Rectangle";
        }

        public double GetSquare() => A * B;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размеры: A:{A} B:{B}");
            Console.WriteLine($"Площадь: {GetSquare():F2}");
        }
    }
}
