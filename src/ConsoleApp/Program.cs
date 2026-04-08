using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        
        string vowels = "аеёиоуыэюя";
        int count = 0;
        
        foreach (char c in input.ToLower())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        
        Console.WriteLine($"Количество гласных: {count}");
    }
}
