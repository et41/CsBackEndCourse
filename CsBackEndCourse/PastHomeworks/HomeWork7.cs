using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork7
    {
        public interface IAreaCalculator
        {
            double GetArea();
        }
        public interface IAreaCalculator2
        {
            double GetArea2();
        }
        public class Circle : IAreaCalculator, IAreaCalculator2
        {
            public double Radius { get; set; }
            public double GetArea()
            {
                return Math.PI * (Radius * Radius);
            }
            public double GetArea2()
            {
                return 3.14 * Radius * Radius;
            }
        }
        public sealed class Circle_Without_I
        {
            public double Radius { get; set; }
            public double GetArea()
            {
                return Math.PI * (Radius * Radius);
            }
        }
        public class Rectangle : IAreaCalculator
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public double GetArea()
            {
                return Height * Width;
            }

        }
        public class Triangle : IAreaCalculator
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public double GetArea()
            {
                return Height * Width * 0.5;
            }
        }
     }

}
