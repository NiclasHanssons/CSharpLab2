using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace ShapeGeneratorProgram
{
    class Program
    {
        public static void RunShapeGeneratorProgram()
        {
            float totalCircumferenceTriangle = 0.0f;
            float avgAreaAllShapes = 0.0f;
            float higestVolumeShape = 0.0f;

            //Skapar en lista och genererar 20st random shapes som sedan hanteras med foreach 
            //loopar för att skriva ut alla shapes, räkna ut circumference, area och volume.
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                //Possible to use Vector3 in method
                shapes.Add(Shape.GenerateShape());
            }

            Console.WriteLine("*** 20 random shapes with random values ***");
            Console.WriteLine();
            int indexOfShape = 1;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{ indexOfShape}: {shape}");
                indexOfShape++;
            }

            //Räknar ut Circumference på alla slumpade triangle
            foreach (Shape shape in shapes)
            {
                if (shape is Triangle triangle)
                {
                    totalCircumferenceTriangle += triangle.Circumference;
                }
            }

            //Sparar arean från alla shapes som delas med antalet shapes för att få avgArea

            foreach (Shape shape in shapes)
            {
                avgAreaAllShapes += shape.Area;
            }
            avgAreaAllShapes = avgAreaAllShapes / shapes.Count;


            //Letar genom alla shapes efter den shape med högst volume
            foreach (Shape shape in shapes)
            {
                if (shape is Shape3D volumeShape)
                {
                    if (volumeShape.Volume > higestVolumeShape)
                    {
                        higestVolumeShape = volumeShape.Volume;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total circumference for triangles: {totalCircumferenceTriangle:F1}");
            Console.WriteLine($"Average area for all shapes: {avgAreaAllShapes:F1}");
            Console.WriteLine($"Highest volume for a shape is: {higestVolumeShape:F1}");
        }

        static void Main(string[] args)
        {
            /**
                Detta program skriver ut 20st slumpade shapes med slumpade
                värden. Dessa värden innefattar X, Y och Z position samt värden för längd, bredd, djup och radie.
                Avslutningsvis skrivs summan av alla trianglars omkrets. Den genomsnittliga arean av alla shapes och
                den shape3D med störst volym.

             */

            //Justerar formateringen av (.) och (,)
            CultureInfo ci = new CultureInfo("us");
            CultureInfo.DefaultThreadCurrentCulture = ci;

            RunShapeGeneratorProgram();
            Console.WriteLine();

            //Exempel inputs för att skriva ut punkterna i en triangel med IEnumerable och IEnumerator
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));
            int corner = 1;

            Console.WriteLine("Positions for THE triangle.");
            foreach (Vector2 v in t)
            {
                Console.WriteLine($"Corner {corner}: {v}");
                corner++;
            }

        }
    }
}
