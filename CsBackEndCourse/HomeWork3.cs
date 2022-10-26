using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork3
    {
        public void ExSerial(string[] list)
        {
            //Serialize and Deserialize for json
            HomeWork2 h_all = new HomeWork2();
            var all_users = h_all.AllUsers(list);

            string fileName = "Users.json";

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(all_users, options);

            File.WriteAllText(fileName, jsonString);
            //Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
