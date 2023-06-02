using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Game> NewGame = new List<Game>();

        int decision = -1;
        int quit = 0;

        int totalPoints = 0;


        string[] words;
        (int s, int e) verse;

        

        do
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Your points are: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start new game");
            Console.WriteLine("     2. List Scores");
            Console.WriteLine("     3. Practice Mode");
            Console.WriteLine("     4. Save Score");
            Console.WriteLine("     5. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            bool checkingInput = int.TryParse(input, out decision);

            if ((input == "")||(!(checkingInput)))
            {
                decision = -1;
            }
            else
            {
                decision = int.Parse(input);
            }
        

            switch (decision)
            {

                case 1:

                Console.Clear();

                NewGame.Clear();

                WordHider hider = new WordHider();
                WordChecker check = new WordChecker();
                PointCounter Points = new PointCounter();

                NewGame.Add(hider);
                NewGame.Add(check);                   
                            
                    Timer timer = new Timer();
                    Console.Write("""Enter the name of the scripture and chapter: (Ex. "Alma 32") """);
                    string filename = Console.ReadLine();
                    Console.Write("Versicle start: ");
                    string start = Console.ReadLine();
                    int startInt = int.Parse(start);
                    Console.Write("Versicle end: ");
                    string end = Console.ReadLine();
                    int endInt = int.Parse(end);

                    Scripture script;

                    ScriptLoad loading = new ScriptLoad(filename, start, end);

                    
                    if(loading.Check(filename, startInt, endInt))
                    {
                        script = new ScriptLoad(filename, start, end);
                        NewGame.Add(script);
                    }

                    else
                    {
                        break;
                    }

                    Console.Clear();


                    Console.WriteLine();
                    Console.WriteLine($"Select a difficulty");
                    Console.WriteLine();
                    Console.WriteLine("     1. Easy");
                    Console.WriteLine("     2. Medium");
                    Console.WriteLine("     3. Hard");
                    Console.Write("Select a choice from the menu: ");
                    int difficulty = int.Parse(Console.ReadLine());

                    hider.SetDifficulty(difficulty);

                    
                    if((difficulty<1)||(difficulty>3))
                    {
                        difficulty = 3;
                    }

                    

                    script.LoadScripture();

                    string[] scriptureList = script.GetScripture();

                    
                    string scripturePlayed = string.Join(" ",script.GetScripture());

                    NewGame[2].Setscripture(hider.HideWords(scripturePlayed));

                    int wordNumber = scriptureList.Count();

                    int hidden = hider.WordsHidden();

                    timer.startGame();

                    NewGame[1].CheckWords(script.GetScripture(), scriptureList);

                    double elapsedTime = timer.endGame();

                    int stillHidden = check.CheckCorrect();

                    int correct = hidden - stillHidden;

                    Points.CalculatePoints(hidden, correct, elapsedTime, startInt, endInt, difficulty);

                    double points = Points.GetPoints();

                    timer.Wait(3);

                    Console.WriteLine("\nWell done!");

                    timer.Wait(3);

                    Console.WriteLine($"It took you {Math.Round(elapsedTime,0)} seconds!");
                    
                    Console.WriteLine($"The amount of words in the game was: {wordNumber}, from which {hidden} were hidden. And you got {correct} words right!");

                    Console.WriteLine($"You won {Math.Round(points,0)} Points!");

                    totalPoints += (int)(points);

                    timer.Wait(5);

                    


                    
                    break;        

                case 2:

                Load load = new Load();

                Console.Clear();

                Console.WriteLine("List of all time best scores! \n\n");

                load.LoadScores();

                Console.WriteLine("\nPress enter to continue. ");
                Console.ReadLine();

            
                    break;

                case 3:

                    Console.Clear();
                    Console.Write("""Enter the name of the scripture and chapter: (Ex. "Alma 32") """);
                    filename = Console.ReadLine();
                    Console.Write("Versicle start: ");
                    start = Console.ReadLine();
                    startInt = int.Parse(start);
                    Console.Write("Versicle end: ");
                    end = Console.ReadLine();
                    endInt = int.Parse(end);

                    

                    loading = new ScriptLoad(filename, start, end);

                    
                    if(loading.Check(filename, startInt, endInt))
                    {
                        script = new ScriptLoad(filename, start, end);
                        NewGame.Add(script);
                    }

                    else
                    {
                        break;
                    }

                    script.LoadScripture();

                    //scripturePlayed = string.Join(" ",script.GetScripture());

                    Console.Clear();

                    Console.WriteLine($"{script.GetPracticeScripture()}");
                    Console.WriteLine("Press enter to continue: ");
                    Console.ReadLine();

                    break;

                case 4:

                    Save save = new Save();

                    save.SavePoints(totalPoints);

                
                    break;

                case 5:

                    quit = 1;

                    break;

                default:

                    break;

            }
        }
        while(quit == 0);

    }
}