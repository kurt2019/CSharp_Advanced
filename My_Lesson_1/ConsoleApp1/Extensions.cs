using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 12. Создайте класс Extensions, в него добавьте extension метод для вашего изначального класса
    public static class Extensions
    {
        public static void extension(this string s)
        {
            Console.WriteLine($"{s}, Кокое то расширения");
        }

        public static string AddStrings(this string s, params string[] strings )
        {
            for (int i = 0; i < strings.Length; i++)
            {
                s += $"{strings[i]} "; 
            }
            return s;
        }




    }
}
