using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ъ
{

    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// Здесь реализован многофункциональный калькулятор, принимающий выражение от пользователя и выводящий результат.
        /// </summary>
        static void Main(string[] args)
        {
            // Приветствие пользователя
            Console.WriteLine("Добро пожаловать в упрощённый калькулятор!");
            Console.WriteLine("Введите математическое выражение (например, 1+2*3) или 'exit' для выхода:");

            while (true)
            {
                try
                {
                    // Ожидание ввода математического выражения
                    Console.Write("Выражение: ");
                    string input = Console.ReadLine();

                    // Выход из программы при вводе 'exit'
                    if (input?.ToLower() == "exit")
                    {
                        Console.WriteLine("Спасибо за использование калькулятора!");
                        break;
                    }

                    // Вычисление результата с использованием DataTable
                    double result = EvaluateExpression(input);

                    // Вывод результата
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок и вывод сообщения
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Вычисляет результат математического выражения.
        /// </summary>
        /// <param name="expression">Строка, содержащая математическое выражение.</param>
        /// <returns>Результат вычислений в формате double.</returns>
        private static double EvaluateExpression(string expression)
        {
            // Использование DataTable для вычисления строки с выражением
            DataTable table = new DataTable();

            // Вычисление выражения и приведение результата к типу double
            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }
    }
}
