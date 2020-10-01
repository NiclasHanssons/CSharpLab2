using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        //Skapar två abstracta properties som sedan klasserna som ärver måste overridea.
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        //Metod för att skapa random float tal
        public static float RandomNumberGenerator()
        {
            Random rndVectorNum = new Random();
            return (float)rndVectorNum.NextDouble() * 10;
        }

        //Metod för att skapa random shapes med random värden.
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

        //Metod för att skapa random shapes där metoden tar en Vector3 som center position. Resterande värden är slumpade.
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

                //Triangle with only 2 generated positions
                case 3:
                    float p1x = RandomNumberGenerator();
                    float p2x = RandomNumberGenerator();
                    float p1y = RandomNumberGenerator();
                    float p2y = RandomNumberGenerator();
                    return new Triangle(new Vector2(p1x, p1y), new Vector2(p2x, p2y), new Vector2((center.X * 3) - p1x - p2x, (center.Y * 3) - p1y - p2y));

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


