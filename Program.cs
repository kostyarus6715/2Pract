using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4 Выход");

        while (true)
        {
            Console.Write("Выберите операцию (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Console.WriteLine("Завершение программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите операцию от 1 до 3.");
                    break;
            }
        }
    }

    static void Addition()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат сложения: {num1 + num2}");
    }
    static void Subtraction()
    {
        Console.Write("Введите уменьшаемое: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вычитаемое: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат вычитания: {num1 - num2}");
    }
    static void Multiplication()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат умножения: {num1 * num2}");
    }
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
