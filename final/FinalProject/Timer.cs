using System;

public class Timer
{
    private TimeSpan _elapsedTime;
    private DateTime startTime;
    private DateTime endTime;

    private double _totalTime;

    public void startGame()
    {
       
        startTime = DateTime.Now;

    }

    public double endGame()
    {
        endTime = DateTime.Now;
        _elapsedTime = endTime - startTime;
        _totalTime = _elapsedTime.TotalSeconds;
        return _totalTime;
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

}