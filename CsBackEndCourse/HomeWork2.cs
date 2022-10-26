using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork2
    {
        public class User
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
        public User RandomSelect(string[] names)
        {
            List<User> users = new List<User>();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                users.Add(new User() { Name = name, Id = i + 1 });
            }

            Random rand = new Random();
            int random_id = rand.Next(1, names.Length);

            Console.WriteLine("Random Id: " + random_id);

            User selected_user = users.Find(user => user.Id == random_id);

            return selected_user;

        }
    }
}
