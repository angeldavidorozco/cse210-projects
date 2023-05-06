using System;

class Program
{
    static void Main(string[] args)
    {

        
        Scripture script = new Scripture();
        WordHider hider = new WordHider();
        

        //int start, end;
        string[] words;
        (int s, int e) verse;

        Console.Write("""Enter the name of the scripture and chapter: (Ex. "Alma 32")""");
        string fileName = Console.ReadLine();
        Console.Write("Versicle start: ");
        var start = Console.ReadLine();
        Console.Write("Versicle end: ");
        var end = Console.ReadLine();

        RefAndVerse RaV;

        if(fileName=="")
        {
            RaV = new RefAndVerse();
        }
        else if((start != "")&(end == ""))
        {
            RaV = new RefAndVerse(fileName, start);
        }
        else if(!(File.Exists(fileName + ".txt")))
        {
            Console.WriteLine("Error 404. File not found. displaying 1 Nephi 1");
            RaV = new RefAndVerse();
        }
        else if((fileName!="")&(start != "")&(end != "")&(int.Parse(start) <= int.Parse(end)))
        {
            RaV = new RefAndVerse(fileName, start, end);
        }

        else
        {
            RaV = new RefAndVerse();
        }
        
        verse = RaV.GetVerse();

        script.Load(RaV.GetReference(), verse.s, verse.e);

        

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