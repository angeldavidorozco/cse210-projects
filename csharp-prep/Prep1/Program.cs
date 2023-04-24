using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What's your first name? ");
        string f_name = Console.ReadLine();
        Console.Write("What's your last name? ");
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {f_name}, {f_name} {l_name}.");
    }
}