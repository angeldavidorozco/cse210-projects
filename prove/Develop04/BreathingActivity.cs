using System;

public class BreathingActivity : Activity
{

    

    public BreathingActivity(int act) : base(act)
    {

        Start(act);

    }

    public void StartBreathing()
    {

        Console.Write("Breathe in:... ");
        CountDown(5);
        Console.WriteLine("");
        Console.Write("Breathe out:...");
        CountDown(6);
        Console.WriteLine("");
        Console.WriteLine("");

    }

}