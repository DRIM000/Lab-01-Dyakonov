using System;

namespace ConsoleApp.Modules
{
    public static class InputModule
    {
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
