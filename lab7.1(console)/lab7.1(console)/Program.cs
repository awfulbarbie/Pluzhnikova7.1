using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7._1_console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            int index1, index2;
            string str1, str2, result;
            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("Пустая строка!");
            }
            else if (!str.Contains("(") || !str.Contains(")"))
            {
                Console.WriteLine("Строка не содержит круглых скобок");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Исходная строка: " + str);

                index1 = str.IndexOf("("); //индекс круглых скобок
                index2 = str.IndexOf(")");
                str1 = str.Substring(0, index1 + 1); //извлекает подстроку из данного экземпляра
                str2 = str.Substring(index2);
                result = str1 + str2;
                Console.WriteLine("Измененная строка: " + result);
            }

        }
    }
}