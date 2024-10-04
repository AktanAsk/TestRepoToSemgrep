using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Проблема 1: Неправильное приведение типа
        object obj = "строка";
        int num = (int)obj; // InvalidCastException

        // Проблема 2: Деление на ноль
        int zero = 0;
        int result = 10 / zero; // DivideByZeroException

        // Проблема 3: Выход за пределы массива
        int[] numbers = { 1, 2, 3 };
        int outOfBounds = numbers[5]; // IndexOutOfRangeException

        // Проблема 4: NullReferenceException
        string nullString = null;
        int length = nullString.Length; // NullReferenceException

        // Проблема 5: Неправильное использование асинхронного метода без await
        ExampleAsyncMethod(); // Предупреждение: асинхронный метод вызывается без await

        // Проблема 6: Использование необъявленной переменной
        Console.WriteLine(undeclaredVariable); // Ошибка компиляции: переменная не объявлена

        // Проблема 7: Попытка изменить неизменяемую строку
        string immutableString = "immutable";
        immutableString[0] = 'I'; // Ошибка компиляции: строки неизменяемы

        // Проблема 8: Несоответствие типов в условии
        int number = 10;
        if (number = 5) // Ошибка: присваивание вместо сравнения
        {
            Console.WriteLine("Ошибка в условии!");
        }

        // Проблема 9: Неверная реализация метода
        int sum = Sum(5, "10"); // Ошибка компиляции: несовместимые типы
    }

    // Асинхронный метод
    static async void ExampleAsyncMethod()
    {
        await Task.Delay(1000);
        Console.WriteLine("Async method completed.");
    }

    // Неправильный метод сложения
    static int Sum(int a, int b)
    {
        return a + b; // Ошибка компиляции: переменная b должна быть int, а не string
    }
}