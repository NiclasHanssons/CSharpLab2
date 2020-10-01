using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : Shape2D , IEnumerator, IEnumerable
    {
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Vector2[] TriangleCorners = new Vector2[3];

        //Del av IEnumerator och IEnumerable implementering. Current är vad som faktiskt returneras till
        //Foreach loopen när vi ex skriver ut item.
        public object Current 
        { 
            get
            {
                return TriangleCorners[position];
            }
        
        }
        
        //Position sätts till -1 då MoveNext() startar med position++ på grund av return ligger efter i koden
        private int position = -1;


        //Triangle tar 3st Vector2 med x och y värde för varje position
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            //TriangleCorners arrayen får värden
            TriangleCorners[0] = new Vector2(p1.X, p1.Y);
            TriangleCorners[1] = new Vector2(p2.X, p2.Y);
            TriangleCorners[2] = new Vector2(p3.X, p3.Y);

            //Räknar ut varje sida i triangle med pythagoras sats
            float acSide = (float)Math.Sqrt((Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2)));
            float baSide = (float)Math.Sqrt((Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2)));
            float bcSide = (float)Math.Sqrt((Math.Pow((p2.X - p3.X), 2) + Math.Pow((p2.Y - p3.Y), 2)));

            Circumference = acSide + baSide + bcSide;
            
            Area = (float)Math.Sqrt((Circumference / 2) * ((Circumference / 2) - acSide) * ((Circumference / 2) - bcSide) * ((Circumference / 2) - baSide));
            
            //Räknar ut center genom medelvärdet på alla x och y positioner var för sig
            Center = new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0);
        }

        //Override ToString för att kunna skriva ut objektets värden och variablar

        public override string ToString()
        {
            return $"triangle @({Center.X:F1}, {Center.Y:F1}): p1({TriangleCorners[0].X:F1}, {TriangleCorners[0].Y:F1}), p2({TriangleCorners[1].X:F1}, {TriangleCorners[1].Y:F1}), p3({TriangleCorners[2].X:F1}. {TriangleCorners[2].Y:F1})"; 
        }

        //Del av IEnumerator och IEnumerable implementering. Anger hur många gånger foreach loopen skall köras
        public bool MoveNext()
        {
            position++;
            return (position < TriangleCorners.Length);
        }

        //Del av IEnumerator och IEnumerable implementering. Nollställer så en ny foreach kan köras.
        public void Reset()
        {
            position = -1;
        }

        //Del av IEnumerator och IEnumerable implementering.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
