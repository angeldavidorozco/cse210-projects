using System;

public class Simple : Goal
{
    private string _name = "Simple Goal";
    private string _fullGoal;

    private string _listGoal;

    //public Simple(string title, string description, int points, bool checkbox): base( title,  description,  points,  checkbox)
    //{
        
    //}

    public override string GetName()
    {
        return _name;
    }

    public override void SetGoal()
    {
        base.SetGoal();

        _fullGoal = $"{_name} ({_description})"; //This needs some work with the formatting

        _listGoal = $"{_title} ({_description})";

    }

    public override string GetListGoal()
    {
        if(_checkbox)
        {
            return $"[X] {_listGoal}";
        }
        else
        {
            return $"[ ] {_listGoal}";
        }
    }

    public override void CheckCompletion()
    {
        _checkbox = true;
    }

    public override int GetPoints()
    {
        return base.GetPoints();
    }

    public override string Save()
    {
        return $"{_name}|{base.Save()}";
    }

    public override void Load(string title, string description, int points, bool checkbox)
    {
        base.Load(title, description, points, checkbox);
        _listGoal = $"{_title} ({_description})";
    }

}