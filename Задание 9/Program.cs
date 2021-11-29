using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Калькулятор C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Введи число №1 и нажми Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число №2 и нажми Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбери действия с числами №1 и №2 из следующего списка:");
            Console.WriteLine("\ta - Сложить");
            Console.WriteLine("\ts - Вычесть");
            Console.WriteLine("\tm - Умножить");
            Console.WriteLine("\td - Разделить");
            Console.Write("Ваш выбор? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Ваш результат: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Ваш результат: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Ваш результат: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Ваш результат: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Нажми любую кнопку чтобы закрыть Калькулятор C#");
            Console.ReadKey();
        }
    }
}
