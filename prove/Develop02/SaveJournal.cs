using System;
using System.IO;


public class SaveJournal 
{

    public string _filename = "";
    public List<string> _newEntries = new List<string>();
    
    public void Save ()
    {

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string line in _newEntries)
            {
                outputFile.WriteLine(line);
            }
    
        }


    }


}