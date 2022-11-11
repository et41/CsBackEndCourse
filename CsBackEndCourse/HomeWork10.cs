using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork10
    {
        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; } = 4;

            public override double  Area()
            {
                return Radius * Radius * Math.PI;
            }
        }
        public class Rectangle : Shape
        {
            public double Height { get; set; } = 2;
            public double Width { get; set; } = 3;

            public override double Area()
            {
                return Height * Width;
            }
        }
        public enum Shapes
        {
            Circle,
            Rectangle
        }

        public class Factory
        {
            public Shape FactoryMethod(Shapes ShapeType)
            {
                Shape shape = null;
                switch (ShapeType)
                { 
                    case Shapes.Circle:
                        shape = new Circle();
                        break;
                    case Shapes.Rectangle:
                        shape = new Rectangle();
                        break;
                }
                return shape;
            }
            
        }
    }
}
