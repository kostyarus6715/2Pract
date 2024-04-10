
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возведение в степень");
        Console.WriteLine("6. Вычисление факториала");
        Console.WriteLine("7. Вычисление квадратного корня");
<<<<<<< HEAD
        Console.WriteLine("8. Вычисление остатка");
        Console.WriteLine("9 Выход");

        while (true)
        {
            Console.Write("Выберите операцию (1-9): ");
=======
        Console.WriteLine("8. Выход");

        while (true)
        {
            Console.Write("Выберите операцию (1-8): ");
>>>>>>> 38600d51bb9f608f86f637da3799f7977e6a858b
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
                    Division();
                    break;
                case "5":
                    Power();
                    break;
                case "6":
                    Factorial();
                    break;
                case "7":
                    SquareRoot();
                    break;
                case "8":
<<<<<<< HEAD
                    Remainder();
                    break;
                case "9":
                    Console.WriteLine("Завершение программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите операцию от 1 до 9.");
=======
                    Console.WriteLine("Завершение программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите операцию от 1 до 8.");
>>>>>>> 38600d51bb9f608f86f637da3799f7977e6a858b
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

    static void Division()
    {
        Console.Write("Введите делимое: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите делитель: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        if (num2 != 0)
            Console.WriteLine($"Результат деления: {num1 / num2}");
        else
            Console.WriteLine("Деление на ноль невозможно.");
    }
<<<<<<< HEAD
    static void Power()
    {
        Console.Write("Введите основание: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите степень: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат возведения в степень: {Math.Pow(num1, num2)}");
    }
    static void Factorial()
    {
        Console.Write("Введите число для вычисления факториала: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        Console.WriteLine($"Факториал числа {num}: {result}");
    }
    static void SquareRoot()
    {
        Console.Write("Введите число для вычисления квадратного корня: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine($"Квадратный корень из {num}: {Math.Sqrt(num)}");
        else
            Console.WriteLine("Нельзя извлечь квадратный корень из отрицательного числа.");
    }
    static void Remainder()
    {
    Console.Write("Введите делимое: ");
    int dividend = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите делитель: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int remainder = dividend % divisor;
    Console.WriteLine($"Остаток от деления {dividend} на {divisor} равен: {remainder}");
    }
    private string GetDebuggerDisplay()
=======

    static void Power()
>>>>>>> 38600d51bb9f608f86f637da3799f7977e6a858b
    {
        Console.Write("Введите основание: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите степень: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Результат возведения в степень: {Math.Pow(num1, num2)}");
    }

    static void Factorial()
    {
        Console.Write("Введите число для вычисления факториала: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        Console.WriteLine($"Факториал числа {num}: {result}");
    }

    static void SquareRoot()
    {
        Console.Write("Введите число для вычисления квадратного корня: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine($"Квадратный корень из {num}: {Math.Sqrt(num)}");
        else
            Console.WriteLine("Нельзя извлечь квадратный корень из отрицательного числа.");
    }
}