using System;

public static class InputHelper
{
    public static string ReadInputOrExit(string message)
    {
        Console.Write(message);
        string text = "";

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Z)
            {
                Console.WriteLine();
                Console.WriteLine("Game closed.");
                Environment.Exit(0);
            }

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                return text;
            }

            if (key.Key == ConsoleKey.Backspace)
            {
                if (text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    Console.Write("\b \b");
                }

                continue;
            }

            text += key.KeyChar;
            Console.Write(key.KeyChar);
        }
    }

    public static string ReadValidName(string message)
    {
        string name;

        do
        {
            name = ReadInputOrExit(message).Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name.");
            }

        } while (string.IsNullOrEmpty(name));

        return name;
    }
}