using System;
using System.IO;

public class WriteNewEntry
{

    public int _i;
    public string _promt;

    public string _newEntry;

    Random rnd = new Random();
    
    public List<string> promts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How productive the day was?",
        "What good actions did you do today?"
    };


    public void GeneratePromt()
    {

    _i = rnd.Next(6);

    _promt = promts[_i];

    Console.WriteLine(promts[_i]);
    Console.Write("-> ");


    }


    public void GenerateEntry()
    {


    string _journalEntry = Console.ReadLine();

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToString("g");

    _newEntry = ($"{dateText} - Promt : {_promt} \n -> {_journalEntry} \n ");

    }


}