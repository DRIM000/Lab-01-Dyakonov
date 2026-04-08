using System;
using ConsoleApp.Modules;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Подсчёт гласных букв (модульная версия) ===\n");

        string input = InputModule.ReadString("Введите строку: ");

        if (!ValidationModule.IsValidString(input))
        {
            Console.WriteLine("Ошибка: строка не может быть пустой!");
            return;
        }

        ProcessingModule.CountAndPrintVowels(input);
    }
}
