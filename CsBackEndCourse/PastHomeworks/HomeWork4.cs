using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBackEndCourse
{
    internal class HomeWork4
    {
       public void ShowAnyAndContains(String check, String[] names, object input_obj)
        {

            if (check == "any")
            {
                int check_num = (int)input_obj;
                bool check_result = names.Any(x => x.Length > check_num);
                if (check_result)
                    Console.WriteLine($"{check_num} harften büyük Isim Bulunmaktadır!");
                else
                    Console.WriteLine($"{check_num} harften büyük isim bulunmamaktadır!");
            }
            else if (check == "contains")
            {
                string input_str = (string)input_obj;
                string upper_input_str = char.ToUpper(input_str[0]) + input_str.Substring(1);
                bool check_result = names.Contains(upper_input_str);
                if (check_result)
                    Console.WriteLine($"Liste {upper_input_str} ismini barındırmaktadır.");
                else
                    Console.WriteLine($"Liste {upper_input_str} ismini barındırmamaktadır.");
            }
        }

    }
}
