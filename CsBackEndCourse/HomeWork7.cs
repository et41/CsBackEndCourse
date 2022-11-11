using System;
using System.Collections.Generic;
using System.Linq;
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
        public class Circle : IAreaCalculator
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

        public  class Triangle
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public double GetArea()
            {
                return Height * Width * 0.5;
            }
        }
        public abstract class Test
        {
            public  void Write()
            {
                Console.WriteLine("Test Abstract Class in Concrete Method");
            }
            public virtual void WriteVirt()
            {
                Console.WriteLine("In virtual");
            }
        }
        public class Test2 : Triangle
        {
            string Write2 { get; set; }
            public void WriteVirt()
            {
                Console.WriteLine("Derived Class");
            }
        }
    }
}
