using Tyuiu.RomashkinaPB.Sprint1.Task2.V8.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчеты и печатает результат на экране.
//рассчеты: известны длины двух сторон прямоугольника. Найти его периметр.
//Число (целое число)
//Периметр прямоугольника (целое число)

namespace Tyuiu.RomashkinaPB.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 1                                                              *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение X");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите значение Y");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Периметр прямоугольника - " + ds.CalculatePerimetr(x, y));

            Console.ReadLine();
        }
    }
}
