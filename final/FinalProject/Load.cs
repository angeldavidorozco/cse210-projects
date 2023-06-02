using System;

public class Load
{
    public void LoadScores()
    {
        string[] scores = System.IO.File.ReadAllLines("Saves.txt");

        
        Dictionary<string, int> dict = new Dictionary<string, int>();


        foreach (string line in scores)
        {
            string[] parts = line.Split("|");

            string user = parts[0];
            int points = int.Parse(parts[1]);

            dict.Add(user, points);


        }

        // Sort the dictionary by value in ascending order
        var sortedList = dict.OrderByDescending(x => x.Value).ToList();

        // Create a new sorted dictionary from the sorted list
        //Dictionary<string, int> sortedDictionary = sortedList.ToDictionary(x => x.Key, x => x.Value);

        foreach (var pair in sortedList)
        {
            Console.WriteLine($"{pair.Key}, {pair.Value}");
        }


    }
}