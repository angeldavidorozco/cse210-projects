using System;

public class ListingActivity : Activity
{

    private List<string> _promtList = new List<string>
    {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    private List<int> usedInts = new List<int>{};

    private List<string> itemsListed = new List<string>{};


    public ListingActivity(int act) : base(act)
    {

        Start(act);

    }

    public void Promtselection()
    {
        

        usedInts.Sort();

        List<int> fullList = new List<int>{0,1,2,3,4,5,6,7,8};

        Random Rnd = new Random();

        int i = Rnd.Next(4);

        Console.WriteLine("List as many responses as you can to the following promt:");

        if(!(usedInts.Contains(i)))
        {
            usedInts.Add(i);

            Console.Write($" ---{_promtList[i]} --- ");
            
            CountDown(10);

            Console.WriteLine("\n");

        }
        else if (usedInts == fullList)
        {

            usedInts.Clear();

        }

    }

    public int listLeght()
    {
        return itemsListed.Count();
    }

    public void StartListing()
    {

        Console.Write("> ");
        itemsListed.Add(Console.ReadLine());

    }

}