using System;
using System.IO;


public class SaveJournal 
{

    public string _filename = "";
    public List<string> newEntries = new List<string>();
    
    public void Save ()
    {

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string line in newEntries)
            {
                outputFile.WriteLine(line);
            }
    
        }


    }


}