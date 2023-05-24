using System;

public class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _checkbox;

    public Goal()
    {

    }

    public Goal(string title, string description, int points, bool checkbox)
    {
        _title = title;
        _description = description;
        _points = points;
        _checkbox = false;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual int GetPoints()
    {
        return _points;
    }
    public bool GetCheckbox()
    {
        return _checkbox;
    }

    public virtual string GetName()
    {
        return "";
    }
    public virtual void SetGoal()
    {

        Console.WriteLine("What's the name of your goal?");
        _title = Console.ReadLine();
        Console.WriteLine("What's a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What are the points associated with it?");
        _points = int.Parse(Console.ReadLine());
        _checkbox = false;
        
    }

    public virtual string GetListGoal()
    {
        return "";
    }

    public virtual void CheckCompletion()
    {
        
    }

    public virtual string Save()
    {
        return $"{GetTitle()}|{GetDescription()}|{GetPoints()}|{GetCheckbox()}";
    }

    public virtual void Load(string title, string description, int points, bool checkbox)
    {
        _title = title;
        _description = description;
        _points = points;
        _checkbox = checkbox;
        
    }

}