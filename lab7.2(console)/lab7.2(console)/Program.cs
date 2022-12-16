using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._2_console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] s = str.Split(); // разбивает начальную строку на массив строк
            int x;
            string t = " ";

            Console.WriteLine("Введите n (количество раз, сколько слова встречаются в строке)");
            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Ошибка! Количество повторений не может иметь отрицательное или нулевое значение!");
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка! Неверный формат ввода данных!");
                Environment.Exit(0);
            }

            string t1 = " ";
            bool flag = false;

            for (int i = 0; i < s.Length; i++)
            {
                x = 0;
                if (t != s[i])
                {
                    foreach (string word in s)
                    {
                        if (s[i] == word)
                        {
                            x++;
                        }
                        if (x > n)
                        {
                            t1 += word + "\n";
                            t = s[i];
                            flag = true;
                            break;
                        }
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine($"Повторяющихся более {n} раз слов нет!");
            }
            else
            {
                Console.WriteLine("Слово повторяется более " + n + " раз: ");
                Console.WriteLine(t1);
            }

        }
    }

}
    
