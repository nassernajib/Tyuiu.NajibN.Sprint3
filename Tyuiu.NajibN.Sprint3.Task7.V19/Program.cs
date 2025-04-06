using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint3.Task7.V19.Lib;
namespace Tyuiu.NajibN.Sprint3.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("* УСЛОВИЕ:  Нассер Нажиб                истнб-24-1                        *");
            Console.WriteLine("* Написать программу, которая выводит таблицу занчений функции            *");
            Console.WriteLine("* F(x) = (5x + 2,5)/(sin(x) - 2) + 2                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага - " + startValue);
            Console.WriteLine("Конец шага - " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив значений функции - " + "[{0}]", string.Join(",", valueArray));
            Console.ReadKey();
        }
    }
}
