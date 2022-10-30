using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    internal abstract class Figure
    {
        public abstract void Area();
    }

    class Rectangle : Figure
    {
        int _a, _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override void Area()
        {
            Console.WriteLine($"Area rectangle: {_a * _b}");
        }
    }

    class Triangle : Figure
    {
        float _a, _b;

        public Triangle(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public override void Area()
        {
            Console.WriteLine($"Area triangle: {_a * _b / 2}");
        }

        public void Show()
        {
            Console.WriteLine("Треугольник");
        }
    }

    class Circle : Figure
    {
        float _radius;
        const float PI = 3.14f;

        public Circle(float r)
        {
            _radius = r;
        }

        public override void Area()
        {
            Console.WriteLine($"Area circle: {PI * _radius * _radius}");
        }
    }
}
