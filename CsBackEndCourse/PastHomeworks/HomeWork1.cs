using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork1
    {
        public int Sum(int number, int[] list)
        {
            // Select number than write sum to console 
            var index = Array.FindIndex(list, item => item == number);

            if (index == -1)
                Console.WriteLine("Sayı dizi içinde değil!");

            int sum = 0;

            for(int i = 0; i < index + 1; i++)
                sum += list[i];

            return sum;        
        }
            
    }
}
