using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Game> NewGame = new List<Game>();
        WordHider hider = new WordHider();
        WordChecker check = new WordChecker();

        NewGame.Add(hider);
        NewGame.Add(check);

        int decision = -1;
        int quit = 0;

        int totalPoints = 0;


        string[] words;
        (int s, int e) verse;

        

        do
        {
            Console.WriteLine();
            Console.WriteLine($"Your points are: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start new game");
            Console.WriteLine("     2. List Scores");
            Console.WriteLine("     3. Practice Mode");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Save Score");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            decision = int.Parse(Console.ReadLine());

        

            switch (decision)
            {

                case 1:

                Console.Clear();

                    

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

                    

                    script.LoadScripture();

                    string[] scriptureList = script.GetScripture();

                    
                    string scripturePlayed = string.Join(" ",script.GetScripture());

                    NewGame[2].Setscripture(hider.HideWords(scripturePlayed));

                    NewGame[1].CheckWords(script.GetScripture(), scriptureList);

                    


                    
                    break;        

                case 2:

            
                    break;

                case 3:

                    break;

                case 4:
                
                
                    break;

                case 5:

                
                    break;

                case 6:

                    quit = 1;
                    break;

            }
        }
        while(quit == 0);

    }
}