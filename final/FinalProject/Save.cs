using System;

public class Save
{

    private string _user;
    private int _oldPoints;

    private List<string> scores = new List<string>();
 
    public void SavePoints(int savedPoints)
    {
        if(CheckUser(savedPoints))
        {
            using(StreamWriter outputFile = new StreamWriter("Saves.txt"))
            {

                foreach(string line in scores)
                {
                outputFile.WriteLine(line);
                }
            }
        }


    }

    private bool CheckUser(int savedPoints)
    {
        Console.WriteLine("Enter your Username: ");
        _user = Console.ReadLine();
        _oldPoints = 0;

        string[] files = System.IO.File.ReadAllLines("Saves.txt");
        
        string newUser = "y";
        bool existingUser = false;

        foreach(string line in files)
        {
            scores.Add(line);
            string[] parts = line.Split("|");
            if (parts[0] == _user)
            {
                existingUser = true;

            }
        }

        if(!(existingUser))
        {
            Console.WriteLine("The user doesn't exist, do you want to create a new one? y/n: ");
            newUser = Console.ReadLine();

            if(newUser.ToLower() == "y")
            {
                scores.Add($"{_user}|{savedPoints}");
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            int i = 0;
            foreach(string line in files)
            {
                string[] parts = line.Split("|");
                if (parts[0] == _user)
                {
                    _oldPoints = int.Parse(parts[1]);
                    scores[i] = $"{_user}|{_oldPoints + savedPoints}";
                }
                i++;
            }
            return true;
        }
    }


}