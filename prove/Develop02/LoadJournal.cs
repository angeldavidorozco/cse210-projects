using System;
using System.IO;


public class LoadJournal
{

    //public int i=0;

    public string _filename = "";

    /*public string _savedEntry = "";

    public List<string> SavedEntries = new List<string>();*/

    public CreateJournal SavedJournal = new CreateJournal();



    public void Load()
    {

        string[] lines = System.IO.File.ReadAllLines(_filename);


        foreach (string line in lines)
        {
                 
            SavedJournal._entries.Add(line);


        }




    }


}