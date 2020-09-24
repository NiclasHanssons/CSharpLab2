using System;
using ShapeLibrary;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ShapeGeneratorProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /**
                Detta program skriver ut 20st slumpade shapes med slumpade
                värden. Dessa värden innefattar X, Y och Z position samt värden för längd, bredd, djup och radie.
                Avslutningsvis skrivs summan av alla trianglars omkrets. Den genomsnittliga arean av alla shapes och
                den shape3D med störst volym.

             */


            /**Test av output och formler för alla shapes
             
            Circle c1 = new Circle(new Vector2(2, 3), 2);
            Console.WriteLine(c1);
            Console.WriteLine($"Circumference: {c1.Circumference:F1}");

            Console.WriteLine();

            Rectangle r1 = new Rectangle(new Vector2(2, 3), 5);
            Console.WriteLine(r1);
            Console.WriteLine($"Area: {r1.Area:F1}");
            Console.WriteLine($"Circumference: {r1.Circumference:F1}");

            Console.WriteLine();

            Triangle t1 = new Triangle(new Vector2(1, 2), new Vector2(3, 6), new Vector2(5, 2));
            Console.WriteLine(t1);
            Console.WriteLine($"Area: {t1.Area:F1}");
            Console.WriteLine($"Circumference: {t1.Circumference:F1}");

            Console.WriteLine();

            Cuboid cb1 = new Cuboid(new Vector3(1, 2, 3),new Vector3(2, 5, 7));
            Console.WriteLine(cb1);
            Console.WriteLine($"Volume: {cb1.Volume:F1}");
            Console.WriteLine($"Area: {cb1.Area:F1}");

            Console.WriteLine();

            Sphere s1 = new Sphere(new Vector3(1, 2, 3), 3);
            Console.WriteLine(s1);
            Console.WriteLine($"Area: {s1.Area:F1}");
            Console.WriteLine($"Volume: {s1.Volume:F1}");
            */
            

            /** Lista och uträkningar

            float totalCircumferenceTriangle = 0.0f;
            float avgAreaAllShapes = 0.0f;
            int numberOfShapes = 0;


            List<Shape> shapes = new List<Shape>();
            
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape triangle in shapes)
            {
                totalCircumferenceTriangle += triangle.;
            }

            foreach (Shape2D shape in shapes)
            {
                avgAreaAllShapes += shape.Area;

            }


            Console.WriteLine(numberOfShapes);
            Console.WriteLine($"Total circumference for triangles: {totalCircumferenceTriangle:F1}");
            Console.WriteLine($"Average area for all shapes: {avgAreaAllShapes:F1}");


            foreach (Shape shape in shapes)
            {

                Console.WriteLine(shape);
                Console.WriteLine();
            }

            */

        }
    }
}
