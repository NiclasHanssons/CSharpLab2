using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public float Radius { get; }

        public Sphere(Vector3 center, float radius)
        {
            Radius = radius;
            Center = new Vector3(center.X, center.Y, center.Z);
            Volume = (4 / 3) * (float)(Math.PI) * (float)Math.Pow(radius, 3);
        }

        public override string ToString()
        {
            return $"sphere @({Center.X:F1}, {Center.Y:F1}, {Center.Z:F1}): r = {Radius:F1}";
        }
    }
}
