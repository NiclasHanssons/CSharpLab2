using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape3D : Shape
    {
        //Lägger till en abstract property volume som måste hanteras av alla klasser som ärver av Shape3D
        public abstract float Volume { get; }
    }
}
