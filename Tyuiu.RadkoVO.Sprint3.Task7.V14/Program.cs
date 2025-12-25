using Tyuiu.RadkoVO.Sprint3.Task7.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Радько В. О. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #21                                                              *");
Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции f(x)       *");
Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
Console.WriteLine("* Произвести проверку деления на 0. При делении на 0 вернуть значение 0.  *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+------------+--------------+");
Console.WriteLine("|     x      |     f(x)     |");
Console.WriteLine("+------------+--------------+");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0, 6:d}      |   {1, 6:f2}     |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+------------+--------------+");
Console.ReadKey();
