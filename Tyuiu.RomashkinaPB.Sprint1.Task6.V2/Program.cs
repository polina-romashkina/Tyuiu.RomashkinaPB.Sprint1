using Tyuiu.RomashkinaPB.Sprint1.Task6.V2.Lib;

//ЗАДАНИЕ:
//Написать программу: пользователь вводит текст.
//Проверить, есть ли в строке Hello.

namespace Tyuiu.RomashkinaPB.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класса String                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, есть ли в строке слово Hello      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckHello(str);
            if (result)
            {
                Console.WriteLine("*Слово 'Hello' найдено в тексте!*");
            }
            else
            {
                Console.WriteLine("*Слово 'Hello' не найдено в тексте.*");
            }
            Console.ReadLine();
        }
    }
}
