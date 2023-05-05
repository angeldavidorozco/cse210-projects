using System;

class Program
{
    static void Main(string[] args)
    {

        
        Scripture script = new Scripture();
        WordHider hider = new WordHider();

        int start, end;
        string[] words;
        (int s, int e) verse;

        Console.Write("Enter the name of the scripture and chapter: ");
        string fileName = Console.ReadLine();
        Console.Write("Versicle start: ");
        start = int.Parse(Console.ReadLine());
        Console.Write("Versicle end: ");
        end = int.Parse(Console.ReadLine());

        RefAndVerse RaV = new RefAndVerse(fileName, start, end);
        
        verse = RaV.GetVerse();

        script.Load(RaV.GetReference(), verse.s, verse.e);

        //verse = RaV.GetVerse();

        words = hider.SeparateScripture(script.GetScripture());

        string decision = "";

        Console.WriteLine($"{RaV.GetReference()} \n\n{script.GetScripture()}");


        

        do
        {
            Console.WriteLine("""Write "quit" to quit, press enter to continue""");
            decision = Console.ReadLine();
            Console.Clear();
            
            if(decision != "quit")
            {
                hider.HideWords();
                Console.WriteLine(RaV.GetReference());
                Console.WriteLine(hider.GetScriptureLeft());
                words = hider.SeparateScripture(hider.GetScriptureLeft());


                foreach (string check in words)
                {
                    if((check == "")|(check == "___"))
                    {
                        decision = "quit";
                    }
                    else if ((char.IsNumber(check[0])))
                    {
                        decision = "quit";
                        
                    }

                    else
                    {
                        decision = "";
                        break;
                    }
                }

            }


        } while (decision != "quit");


    }
}