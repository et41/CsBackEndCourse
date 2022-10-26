using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] names =
            {
                "Resul",
                "Kemal Erdem",
                "Yağmur",
                "Aytin",
                "Mücahid",
                "Beytullah",
                "Yasin",
                "Ayaz",
                "Ahsen",
                "Halime",
                "Onur",
                "Yiğit",
                "Musa",
                "Alper Umur",
                "Emre",
                "Kemal",
                "Elif Nur",
                "Ebru",
                "Semih",
                "Eren",
                "Beytullah",
                "Can",
                "Berkcan",
                "Doğuş",
                "Ramazan Burak"
            };

            // Select user from list with random number
            HomeWork2 h2 = new HomeWork2();
            var selected_user = h2.RandomSelect(names);

            Console.WriteLine(selected_user.Id + " " + selected_user.Name);

            // Select number than write sum to console 
            int[] c = { 1, 21, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(String.Join(", ", c));
            Console.WriteLine("Yukarıdaki listeden kendisine kadar olan sayıların toplamını bulmak istediğiniz elemanı yazın: ");
            int number = Convert.ToInt32(Console.ReadLine());

            HomeWork1 h1 = new HomeWork1();
            int sum = h1.Sum(number, c);
            Console.WriteLine("Toplam:" + sum);

        }
    }
}
