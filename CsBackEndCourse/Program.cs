using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
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

            #region 
            //PAST HOMEWORKS
            /*
            
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

            //Json Serialize and Deserialize
            HomeWork3 h3 = new HomeWork3();
            h3.ExSerial(names);
            */
            #endregion

            HomeWork2 h2 = new HomeWork2();
            var all_students = h2.AllUsers(names);


            //contains and any
            HomeWork4 h4 = new HomeWork4();
            Console.WriteLine("Karşılaştırmak isteğiniz uzunluk değerini giriniz:");
            object input_arg;
            input_arg = Convert.ToInt32(Console.ReadLine());
            h4.ShowAnyAndContains("any", names, input_arg);

            Console.WriteLine("Listede olup olmadığını kontrol etmek istediğiniz ismi giriniz: ");
            input_arg = Console.ReadLine();
            h4.ShowAnyAndContains("contains", names, input_arg);
    
            //fibonacci 
            HomeWork5 h5 = new HomeWork5();
            int index = 9;
            h5.Fibo(index);
               
            //IOC
            HomeWork6 h6 = new HomeWork6();
            var logic = new HomeWork6.CustomerBusinessLogic();
            var name = logic.GetCustomerName(2);
            Console.WriteLine(name);

            //dapper
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "server=localhost;Database=BootCamp;Integrated Security=True;";

                connection.Open();
                Console.WriteLine($"Connection State : {connection.State}");
                Console.WriteLine($"Connection String : {connection.ConnectionString}");
                foreach (var item in names)
                {
                    connection.Execute("insert into Student(Name) " + 
                        "values(@Name)", 
                        new Student() { Name = item} 
                        );
                }
                List<Student> students = connection.Query<Student>("SELECT * FROM Student").ToList();
                if(students.Count > 0)
                {
                    foreach (var item in students)
                    {
                        Console.WriteLine($"{item.Id}: {item.Name}");
                    }
                }
                connection.Close();
            }
 


        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
