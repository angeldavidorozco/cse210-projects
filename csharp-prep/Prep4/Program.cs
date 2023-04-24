using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() ;

        int user_input = -1;
        string response;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");



        while(user_input != 0)
        
        {

            Console.Write("Enter a number: ");
            response = Console.ReadLine();
            user_input = int.Parse(response);

            if(user_input != 0)
            {

                numbers.Add(user_input);

            }


        }

        int sum = 0;

        foreach (int number in numbers) 
        {

            sum = sum + number;

        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");






        int max = numbers[0];
        

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}