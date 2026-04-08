using System;

namespace ConsoleApp.Modules
{
    public static class ProcessingModule
    {
        public static void CountAndPrintVowels(string input)
        {
            string vowels = "аеёиоуыэюя";
            int count = 0;

            foreach (char c in input.ToLower())
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество гласных букв: {count}");
        }
    }
}
