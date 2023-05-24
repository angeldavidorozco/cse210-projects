using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>{};

        int decision = -1;
        int quit = 0;
        int goalDecision = -1;

        int check = 0;

        int i;

        int totalPoints = 0;

        int partialPoints;

        

        do
        {
            Console.WriteLine();
            Console.WriteLine($"Your points are: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            decision = int.Parse(Console.ReadLine());

        

            switch (decision)
            {

                case 1:

                    check = 1;

                    Console.Clear();

                    Console.WriteLine("Select a goal type:");
                    Console.WriteLine("     1. Simple Goal");
                    Console.WriteLine("     2. Eternal Goals");
                    Console.WriteLine("     3. Checklist Goals");
                    Console.Write("Select a choice from the menu: ");
                    goalDecision = int.Parse(Console.ReadLine());

                    if(goalDecision == 1)
                    {
                        Simple s1 = new Simple{};

                        s1.SetGoal();

                        goals.Add(s1);
                

                    }
                    else if(goalDecision == 2)
                    {

                        Eternal e1 = new Eternal{};

                        e1.SetGoal();

                        goals.Add(e1);

                        
                    }
                    else if(goalDecision == 3)
                    {

                        Checklist c1 = new Checklist{};

                        c1.SetGoal();

                        goals.Add(c1);

                    }

                    else
                    {
                        Console.WriteLine("Invalid Goal Type!");
                    }
                
                    break;

                case 2:

                Console.WriteLine("Your goals are: ");

                i = 1;

                foreach(Goal goal in goals)
                {
                  
                  Console.WriteLine($"{i}. {goal.GetListGoal()}");
                  i++;

                }
                
                    break;

                case 3:

                Console.WriteLine("What will be the name of the text file?: (Add the extension .txt at the end) ");
                string filename = Console.ReadLine();

                string ow = "y";

                if(File.Exists(filename))
                {
                    Console.WriteLine("The file already exist, do you wish to overwrite? y/n");
                    ow = Console.ReadLine();
                }

                if(ow.ToLower() == "y")
                {
                    check = 0;

                    Console.WriteLine("Error 404: File Not Found!");
                
                    using(StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(totalPoints);
                        foreach(Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.Save());
                        }

                    }
                }
                else{}

                    break;

                case 4:

                Console.WriteLine("What's the name of the text file you want to load?: (Add the extension .txt at the end) ");

                string loadName = Console.ReadLine();

                if(!(File.Exists(loadName)))
                {
                    Console.WriteLine("Error 404: File Not Found!");
                }
                else{

                string[] points = System.IO.File.ReadAllLines(loadName);

                goals.Clear();

                totalPoints = int.Parse(points[0]);

                string[] lines = points.Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string goalName = parts[0];

                    if(goalName == "Simple Goal")
                    {
                        Simple s1 = new Simple{};

                        s1.Load(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));          
                        goals.Add(s1);

                    }
                    else if(goalName == "Eternal Goal")
                    {

                        Eternal e1 = new Eternal{};

                        e1.Load(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                        e1.LoadEternal(int.Parse(parts[5]));

                        goals.Add(e1);

                        
                    }
                    else if(goalName == "Checklist Goal")
                    {

                        Checklist c1 = new Checklist{};

                        c1.Load(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                        c1.LoadChecklist(int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7]));

                        goals.Add(c1);

                    }
                }
                }
                
                    break;

                case 5:

                Console.WriteLine("Your goals are: ");

                i = 1;

                check = 1;

                foreach(Goal goal in goals)
                {
                  
                  Console.WriteLine($"{i}. {goal.GetTitle()}");
                  i++;

                }

                Console.WriteLine("Which goal did you accomplish? ");

                int acc = int.Parse(Console.ReadLine());

                if (acc-1<= goals.Count() - 1)
                {

                goals[acc-1].CheckCompletion();

                partialPoints = goals[acc-1].GetPoints();

                totalPoints += partialPoints;

                }
                else {Console.Write("Please select a valid goal!");}

                    break;

                case 6:

                    string uc = "y";

                    if (check==1)
                    {
                        Console.WriteLine("You have unsaved changes, do you want to exit? y/n");
                        uc = Console.ReadLine();

                    }

                    if(uc.ToLower() == "y")
                    {
                    quit = 1;
                    }
                    else{}
                    break;

                default:

                    break;

            }
        }
        while(quit == 0);

            

        






























        // title,  description,  points,  checkbox,  name

        //goals.Add(new Simple("Title", "something simple", 50, false, "Simple goal:"));
        //goals.Add(new Eternal("Title", "something eternal", 50, false, "Eternal goal:"));
        //goals.Add(new Checklist("Title", "something checboxy", 50, false, "Checklist goal:", 4, 500));

        //foreach(Goal goal in goals)
        //{
        //    Console.WriteLine($"{goal.GetDescription()} -> {goal.GetName()}");
        //}
    }
}