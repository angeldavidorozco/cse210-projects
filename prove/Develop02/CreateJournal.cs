using System;

public class CreateJournal
{

    public List<string> _entries = new List<string>();

    

  


    public void DisplayJournal()
    {

        foreach (string line in _entries)
        {

            Console.WriteLine(line);

        }


    } 




   


}