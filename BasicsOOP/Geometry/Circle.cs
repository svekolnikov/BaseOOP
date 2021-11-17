﻿using System;
using System.Drawing;

namespace BasicsOOP.Geometry
{
    internal class Circle : Point
    {
        public float Radius { get; }

        public Circle(float x, float y, bool isVisible, Color color, float radius) 
            : base(x, y, isVisible, color)
        {
            Radius = radius;
            Name = "Circle";
        }

        public double GetSquare() => Math.PI*Radius*Radius;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Radius}");
            Console.WriteLine($"Площадь: {GetSquare():F2}");
        }
    }
}
