using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static float RandomNumberGenerator()
        {
            Random rndVectorNum = new Random();
            return (float)rndVectorNum.NextDouble() * 10;

        }

        public static Shape GenerateShape()
        {
            Random rndNum = new Random();
            int randomShape = rndNum.Next(0, 7);

            switch (randomShape)
            {
                case 0:
                    return new Circle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());

                //Rectangle
                case 1:
                    return new Rectangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));

                //Square
                case 2:
                    return new Rectangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());

                case 3:
                    return new Triangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));

                //Cuboid
                case 4:
                    return new Cuboid(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()));

                //Cube
                case 5:
                    return new Cuboid(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());

                default:
                    return new Sphere(new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()), RandomNumberGenerator());

            }
        }


        public static Shape GenerateShape(Vector3 center)
        {
            Random rndNum = new Random();
            int randomShape = rndNum.Next(0, 7);

            switch (randomShape)
            {
                case 0:
                    return new Circle(new Vector2(center.X, center.Y), RandomNumberGenerator());

                //Rectangle
                case 1:
                    return new Rectangle(new Vector2(center.X, center.Y), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));

                //Square
                case 2:
                    return new Rectangle(new Vector2(center.X, center.Y), RandomNumberGenerator());

                case 3:
                    return new Triangle(new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()), new Vector2(RandomNumberGenerator(), RandomNumberGenerator()));

                //Cuboid
                case 4:
                    return new Cuboid(center, new Vector3(RandomNumberGenerator(), RandomNumberGenerator(), RandomNumberGenerator()));

                //Cube
                case 5:
                    return new Cuboid(center, RandomNumberGenerator());

                default:
                    return new Sphere(center, RandomNumberGenerator());

            }
        }
    }
}


