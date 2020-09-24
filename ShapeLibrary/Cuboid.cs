using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public bool IsCube 
        {
            get 
            {

                if (Size.X == Size.Y)
                {
                    if (Size.X == Size.Z)
                    {
                        return true;
                    }
                }
                return false;
            } 
        }

        public Vector3 Size { get; }
       

        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = new Vector3(center.X, center.Y, center.Z);
            Volume = size.X * size.Y * size.Z;
            Area = 2 * ((size.X * size.Y) + (size.Z * size.Y) + (size.X * size.Z)); 
            Size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            Center = new Vector3(center.X, center.Y, center.Z);
            Area = (width * width) * 6;
            Volume = width * width * width;
            Size = new Vector3(width, width, width);
        }

        public override string ToString()
        {
            return $"cuboid @({Center.X:F1}, {Center.Y:F1}, {Center.Z:F1}): w = {Size.X:F1}, h = {Size.Y:F1}, l = {Size.Z:F1}, IsCube: {IsCube}";
        }

    }
}
