using System;

public class Timer
{
    private TimeSpan _elapsedTime;
    private DateTime _startTime;
    private DateTime _endTime;

    private double _totalTime;

    public void startGame()
    {
       
        _startTime = DateTime.Now;

    }

    public double endGame()
    {
        _endTime = DateTime.Now;
        _elapsedTime = _endTime - _startTime;
        _totalTime = _elapsedTime.TotalSeconds;
        return _totalTime;
    }

    public void Wait(int duration)
    {

        List<string> animationString = new List<string>{"|", "/","-", "\\"};
        
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(duration);

        int i = 0;
        
        while(DateTime.Now < _endTime)
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