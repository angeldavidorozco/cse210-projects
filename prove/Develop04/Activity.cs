using System;

public class Activity
{
    private List<string> descriptionList = new List<string>{"This activity will help you relax by walking you through breathing in and out slowly. \nclear your mind and focus on your breathing","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the porwe you have and how you can use it in other aspects of your life.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."};

    private List<string> nameList = new List<string>{"Breathing Activity", "Reflecting Activity", "Listing Activity"};

    private string _description;

    private int _duration;

    private string _durationQuestion;

    private int _total;

    public Activity(int act)
    {
        _description = descriptionList[act];
        //_duration = duration;
        _durationQuestion = "How long, in seconds would you like your session?";
    }

    public void Wait(int duration)
    {

        List<string> animationString = new List<string>{"|", "/","-", "\\"};
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        
        while(DateTime.Now < endTime)
        {

            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if(i >= animationString.Count)
            {
                i = 0;
            }


        }

    }

    public void CountDown(int duration)
    {
        for (int i = duration ; i >= 0; i--)
        {
            if(i>=10 && i<= 99)
            {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
            }
            else{
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
        }
    }

    public int Start(int i)
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {nameList[i]}\n\n");
        Console.WriteLine($"{GetDescription()}");

        Console.Write($"\n{_durationQuestion} ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        return  _duration;

    }

    public void Intro()
    {
        Console.Clear();

        Console.Write("Get ready... ");

        Wait(4);

        Console.WriteLine("\n\n");
    }



    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void end(int i)
    {
        Console.WriteLine("Well done!");
        Wait(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {nameList[i]}");
        Console.WriteLine("");
        Wait(5);

        
    }


}