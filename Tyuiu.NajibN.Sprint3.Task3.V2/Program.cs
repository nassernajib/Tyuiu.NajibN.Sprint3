using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint3.Task3.V2.Lib;
namespace Tyuiu.NajibN.Sprint3.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Нассер Нажиб | ПКТб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Оператор цикла foreach                                              *");
            Console.WriteLine("*Задание #3                                                                *");
            Console.WriteLine("*Вариант #2                                                                *");
            Console.WriteLine("*Выполнил: Нассер Нажиб                | ПКТб-24-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв z,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: asdzzz vfvfzz v gthvz         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            string value = "asdzzz vfvfzz v gthvz";
            char chr = 'z';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + chr);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Колличество символов = " + ds.GetMaxCharCount(value, chr));
            Console.ReadLine();
        }
    }
}
