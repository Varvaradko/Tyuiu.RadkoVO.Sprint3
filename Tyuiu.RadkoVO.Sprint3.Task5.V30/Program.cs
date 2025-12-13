using Tyuiu.RadkoVO.Sprint3.Task5.V30.Lib;

namespace Tyuiu.RadkoVO.Sprint3.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Вложенные циклы                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Радько Варвара Олеговна | СМАРТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine("Переменная x: " + x);
            int startValue1 = 1;
            Console.WriteLine("Старт шага 1: " + startValue1);
            int stopValue1 = 3;
            Console.WriteLine("Конец шага 1: " + stopValue1);
            int startValue2 = 1;
            Console.WriteLine("Старт шага 2: " + startValue2);
            int stopValue2 = 11;
            Console.WriteLine("Конец шага 2: " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}