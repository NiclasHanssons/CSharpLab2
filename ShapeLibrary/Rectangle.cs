using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Vector2 Size { get; }

        //Kontrollerar om shapen är en square, om inte är det en rectangle
        public bool IsSquare 
        {
            get
            {
                return Size.X == Size.Y;
            } 
        }

        //Rectangle då Vector2 tar size (x and y)
        public Rectangle(Vector2 center, Vector2 size)
        {
            Center = new Vector3(center, 0);
            Area = size.X * size.Y;
            Size = size;
            Circumference = size.X * 2 + size.Y * 2;
        }

        //Square då Vector2 tar endast en width
        public Rectangle(Vector2 center, float width)
        {
            Center = new Vector3(center, 0);
            Area = width * width;
            Size = new Vector2(width, width);
            Circumference = width * 4;
        }
        
        //Override ToString för att kunna skriva ut objektets värden och variablar
        public override string ToString()
        {
            return $"rectangle @({Center.X:F1}, {Center.Y:F1}): w = {Size.X:F1}, h = {Size.Y:F1}, IsSquare: {IsSquare}";
        }
    }
}
