using System;


public class ReflectingActivity : Activity
{
    private List<string> _promtList = new List<string>
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};

    private List<string> _questionList = new List<string>
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    List<int> usedInts = new List<int>{};
    

    public ReflectingActivity(int act) : base(act)
    {

        Start(act);

    }

    public void StartReflecting()
    {
        usedInts.Sort();

        List<int> fullList = new List<int>{0,1,2,3,4,5,6,7,8};

        Random Rnd = new Random();

        int i = Rnd.Next(8);

        if(!(usedInts.Contains(i)))
        {
            usedInts.Add(i);

            Console.Write($"{_questionList[i]} ");
            
            Wait(8);

            Console.WriteLine("\n");

        }
        else if (usedInts == fullList)
        {

            usedInts.Clear();

        }


    }

    public List<string> GetPromts()
    {
        return _promtList;
    }

    public List<string> GetQuestions()
    {
        return _questionList;
    }


}