using System;

public class Game 
{
    protected int _difficulty;

    protected string[] _scripture;

    public int GetDifficulty()
    {
        return _difficulty;
    }

    public void SetDifficulty(int diff)
    {
        _difficulty = diff;
        if (diff > 3 || diff < 1)
        {
            Console.WriteLine("Invalid difficulty, setting it to defaul: Hard.");
        }
    }


    public virtual void Setscripture(string[] scripture)
    {

        _scripture = scripture;

    }

    public virtual void CheckWords(string[] scripture, string[] _checkedScripture)
    {

    }

}