using System;

namespace ConsoleApp.Modules
{
    public static class ValidationModule
    {
        public static bool IsValidString(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
    }
}
