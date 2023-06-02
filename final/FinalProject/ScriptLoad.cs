using System;
using System.Text.RegularExpressions;

public class ScriptLoad:Scripture
{
    private int _lastVerse;

    private string _practiceScript;

    public ScriptLoad(string reference, string start, string ending):base(reference,start,ending)
    {

    }

    public bool Check(string filename, int verseStart, int verseEnd)
    {
        if((verseStart > verseEnd)||(verseStart < 0))
        {
            Console.WriteLine("Invalid verse");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
            return false;
        }

        string file = filename + ".txt";

        if(!(File.Exists(file)))
        {
            Console.WriteLine("Error 404. File not found");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
            return false;
        }
        
        

        string[] lines = System.IO.File.ReadAllLines(file);

        lines = lines.Skip(2).ToArray();

        string value = "";


        

        foreach (string line in lines)
        {

            value = Regex.Match(line, @"\d+").Value;

            if(line == "")
            {
                continue;
            }

            _lastVerse = int.Parse(value);
        }

        if (_lastVerse < verseEnd)
        {
            Console.WriteLine($"Error. The scripture is only {_lastVerse} versicles long");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
            return false;
        }

        return (_lastVerse >= verseEnd);

    }
    

    public override void LoadScripture()
    {

        (int start, int end) verse = GetVerse();

        string filename = GetReference() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        lines = lines.Skip(2).ToArray();

        string scriptConstructor = "";
        string value = "";


        

        foreach (string line in lines)
        {

            value = Regex.Match(line, @"\d+").Value;


            if(line == "")
            {
                continue;
            }

            if(int.Parse(value) >= verse.start && int.Parse(value) <= verse.end)
            {
                scriptConstructor = line;
                _wholeScript += scriptConstructor + "\n\n";
            }

        }

        _practiceScript = _wholeScript;

        char[] separators = new char[] { ' ', '\n' };

        string[] subs = _wholeScript.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Setscripture(subs);

        //Setscripture(_wholeScript.Split(" "));


    }

    
}