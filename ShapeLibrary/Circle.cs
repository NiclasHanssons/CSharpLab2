using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public float Radius { get; }

        public Circle(Vector2 center, float radius)
        {
            Radius = radius;
            Center = new Vector3(center, 0);
            Circumference = (float)(2 * Math.PI * radius);
            Area = (float)(Math.PI * Math.Pow(radius, 2));
        }

        //Override ToString för att kunna skriva ut objektets värden och variablar

        public override string ToString()
        {
            return $"circle @({Center.X:F1}, {Center.Y:F1}): r = {Radius:F1}";
        }
    }
}
