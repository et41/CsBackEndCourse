using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
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

            var encoderSettings = new TextEncoderSettings();
            encoderSettings.AllowCharacters('\u011f', '\u011e', '\u0131', '\u0130', '\u00f6', '\u00d6', '\u00fc', '\u00dc', '\u015f', '\u015e', '\u00e7', '\u00c7');
            encoderSettings.AllowRange(UnicodeRanges.BasicLatin);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(encoderSettings),
            };
            string jsonString = JsonSerializer.Serialize(all_users, options);

            File.WriteAllText(fileName, jsonString);
            //Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
