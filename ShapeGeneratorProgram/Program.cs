using System;
using ShapeLibrary;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;

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

            CultureInfo ci = new CultureInfo("us");
            CultureInfo.DefaultThreadCurrentCulture = ci;

            float totalCircumferenceTriangle = 0.0f;
            float avgAreaAllShapes = 0.0f;
            float higestVolumeShape = 0.0f;

            //Skapar en lista och genererar 20st random shapes som sedan hanteras med foreach 
            //loopar för att skriva ut alla shapes, räkna ut circumference, area och volume.
            List<Shape> shapes = new List<Shape>();
            
            for (int i = 0; i < 20; i++)
            {
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
            Console.WriteLine($"Shape with highest volume is: {higestVolumeShape:F1}");

            

            



        }
    }
}
