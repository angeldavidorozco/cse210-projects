using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class Scripture
{

    private string _scripture;
    //private string _filename;

    private string _wholeScript;

    //private List<string> _referenceList = new List<string>();

    public string GetScripture()
    {
        return _scripture;
    }

    public void Setscripture(string scripture)
    {

        _scripture = scripture;

    }

    /*public string GetFilename()
    {
        return _filename;
    }

    public void SetFilename(string filename)
    {

        _filename = filename;

    }*/


     public void Load(string fileName, int verseStart, int verseEnd)
    {

        fileName = fileName + ".txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

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

            if(int.Parse(value) >= verseStart && int.Parse(value) <= verseEnd)
            {
                scriptConstructor = line;
                _wholeScript += scriptConstructor + "\n\n";
            }

        }

        Setscripture(_wholeScript);


    }

}