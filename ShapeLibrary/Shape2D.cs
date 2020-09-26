using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape2D : Shape
    {
        //Lägger till en abstract property circumference som måste hanteras av alla klasser som ärver av Shape2D

        public abstract float Circumference { get; }
    }
}
