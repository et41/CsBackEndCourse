using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork5
    {
        public void Fibo(int index)
        {
            int a = 1;
            int b = 1;
            int sum;

            Console.WriteLine($"{a}\n{b}");
            for (int i = 0; i < index; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.WriteLine(b);
            }
        }
    }

}
