using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint3.TaskReview.V11.Lib;

namespace Tyuiu.ShunanovKE.Sprint3.TaskReview.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#3 | Выполнил: Шунанов К. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Шунанов Кирилл Ерболатович | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на         *");
            Console.WriteLine("* заданном диапазоне [-5,5] с шагом 1. Произвести проверку деления на 0.  *");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Значение окргулить до двух      *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5, end = 5;
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);
            int len = end - start + 1;
            double[] res = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            int cnt = 0;
            for (int x = start; x <= end; x++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}  |", x, res[cnt]);
                cnt++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
