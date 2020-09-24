using System;
using ShapeLibrary;
using System.Numerics;
using System.Collections.Generic;

namespace ShapeGeneratorProgram
{
    class Program
    {
        //public static double RandomNumberGenerator()
        //{
        //    Random rndVectorNum = new Random();
        //    return rndVectorNum.NextDouble() * 10;
            
        //}
        static void Main(string[] args)
        {
            /*Detta program skall skriva ut 20st random shapes med random
             * värden. Samt de tre sammanfattningarna.
             * 
             */
            //Random rndVectorNum = new Random();

            //Console.WriteLine($"{RandomNumberGenerator():F1}");


            //Vector2 circleVector2Input = new Vector2(rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6));
            //Circle c1 = new Circle(circleVector2Input, rndVectorNum.Next(1, 6));

            //Console.WriteLine(c1.ToString());

            //Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));

            //Console.WriteLine($"Area av c1 är {c1.Area}");
            //Console.WriteLine($"Omkrets av c1 är {c1.Circumference}");

            //Console.WriteLine("***REKTANGEL***");
            //Vector2 rectangleVector2InputCenter = new Vector2(rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6));
            //Vector2 rectangleVector2InputHeightWidth = new Vector2(rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6));

            //Rectangle r1 = new Rectangle(rectangleVector2InputCenter, rectangleVector2InputHeightWidth);
            //Console.WriteLine(r1);

            //Rectangle r2Square = new Rectangle(rectangleVector2InputCenter, 4.0f);
            //Console.WriteLine(r2Square);

            //Console.WriteLine("***CUBOID***");
            //Console.WriteLine();

            //Vector3 cuboidVector3InputCenter = new Vector3(rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6));
            //Vector3 cuboidVector3InputSize = new Vector3(rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6), rndVectorNum.Next(1, 6));


            //Cuboid cuboid1 = new Cuboid(cuboidVector3InputCenter, cuboidVector3InputSize);
            //Console.WriteLine(cuboid1);

            //Console.WriteLine();

            //Console.WriteLine("Testing lika hörn");
            //Console.WriteLine(new Cuboid(new Vector3(1, 2, 3), 4.0f));

            //Console.WriteLine("***SPHERE***");
            //Sphere sp1 = new Sphere(cuboidVector3InputCenter, 2.0f);
            //Console.WriteLine(sp1.Volume);

            //Console.WriteLine("***TRIANGLE***");
            //Console.WriteLine(new Triangle(new Vector2(0, 0), new Vector2(3, 3), new Vector2(6, 0)));
            //Triangle tr1 = new Triangle(new Vector2(0, 0), new Vector2(3, 3), new Vector2(6, 0));
            //Console.WriteLine(tr1.Circumference);

            //Console.WriteLine(tr1.Area);
            List<Shape> shapes = new List<Shape>();
            
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine();
            }


        }
    }
}
