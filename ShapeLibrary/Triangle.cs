using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : Shape2D
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Vector2 Position1 { get; }
        public Vector2 Position2 { get; }
        public Vector2 Position3 { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            Position1 = new Vector2(p1.X, p1.Y);
            Position2 = new Vector2(p2.X, p2.Y);
            Position3 = new Vector2(p3.X, p3.Y);

            float acSide = (float)Math.Sqrt((Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2)));
            float baSide = (float)Math.Sqrt((Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2)));
            float bcSide = (float)Math.Sqrt((Math.Pow((p2.X - p3.X), 2) + Math.Pow((p2.Y - p3.Y), 2)));

            Circumference = acSide + baSide + bcSide;
            
            Area = (float)Math.Sqrt((Circumference / 2) * ((Circumference / 2) - acSide) * ((Circumference / 2) - bcSide) * ((Circumference / 2) - baSide));
            
            Center = new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0);
        }

        public override string ToString()
        {
            return $"triangle @({Center.X:F1}, {Center.Y:F1}): p1({Position1.X:F1}, {Position1.Y:F1}), p2({Position2.X:F1}, {Position2.Y:F1}), p3({Position3.X:F1}. {Position3.Y:F1})"; 
        }
    }
}
