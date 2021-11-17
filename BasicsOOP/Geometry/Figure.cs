using System;
using System.Drawing;

namespace BasicsOOP.Geometry
{
    internal abstract class Figure
    {
        public virtual string Name => "Figure";
        public bool IsVisible { get; }

        public Color Color { get; private set; }

        public float X { get; protected set; }

        public float Y { get; protected set; }

        protected Figure(float x, float y, bool isVisible, Color color)
        {
            X = x;
            Y = y;
            IsVisible = isVisible;
            Color = color;
        }

        public bool GetState() => IsVisible;

        public void SetColor(Color color)
        {
            Color = color;
            Console.WriteLine($"Установлен новый цвет: {color}");
        } 

        public void MoveX(float x)
        {
            X += x;
            Console.WriteLine($"Передвижение {Name} по X на: {x}. Новое значение {X}");
        }

        public void MoveY(float y)
        {
            Y += y;
            Console.WriteLine($"Передвижение {Name} по Y на: {y}. Новое значение {Y}");
        }

        public virtual void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Координаты X:{X} Y:{Y}");
            Console.WriteLine($"Цвет:{Color}");
            Console.WriteLine($"Состояние:{IsVisible}");
        }
    }
}
