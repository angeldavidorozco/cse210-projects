using System;

public class Game 
{
    private int _difficulty;

    protected string[] _scripture;

    public int GetDifficulty()
    {
        return _difficulty;
    }

    public void SetDifficulty(int diff)
    {
        _difficulty = diff;
    }

    public virtual void Setscripture(string[] scripture)
    {

        _scripture = scripture;

    }

    public virtual void CheckWords(string[] scripture, string[] _checkedScripture)
    {

    }

}