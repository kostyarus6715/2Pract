using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2 Выход");

        while (true)
        {
            Console.Write("Выберите операцию (1-2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Console.WriteLine("Завершение программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите операцию от 1 до 2.");
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
}
