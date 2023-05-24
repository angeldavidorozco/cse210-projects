using System;

public class Checklist : Goal
{
    private string _name = "Checklist Goal";
    private int _completion = 0;

    private int _maxCompletion;
    private int _bonus;
    private string _fullGoal;

    private string _listGoal;

    //public Checklist(string title, string description, int points, bool checkbox, string name, int completion, int bonus): base( title,  description,  points,  checkbox)
    //{
    //    _name = name;
    //    _completion = completion;
    //    _bonus = bonus; 
    //}

    public int GetCompletion()
    {
        return _completion;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override string GetName()
    {
        return _name;
    }

    public override void CheckCompletion()
    {
        if(_completion<_maxCompletion-1)
        {
            _completion++;
        }
        else
        {
            _completion++;
            _checkbox = true;
        }
    }

    public void LoadChecklist(int completion, int maxCompletion, int bonus)
    {
        _completion = completion;
        _maxCompletion = maxCompletion;
        _bonus = bonus;
    }

    public override void SetGoal()
    {
        base.SetGoal();

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        _maxCompletion = int.Parse(Console.ReadLine());
        Console.WriteLine("What's the bonus for accomplising it?");
        _bonus = int.Parse(Console.ReadLine());

        _fullGoal = $"{_name} ({_description}), {_completion}/{_maxCompletion} {_bonus}";

        _listGoal = $"{_title} ({_description}) -- Currently completed: {_completion}/{_maxCompletion}";

    }

    public override string GetListGoal()
    {
        _listGoal = $"{_title} ({_description}) -- Currently completed: {_completion}/{_maxCompletion}";

        if(_checkbox)
        {
            return $"[X] {_listGoal}";
        }
        else
        {
            return $"[ ] {_listGoal}";
        }
    }

    public override int GetPoints()
    {
        if (_checkbox)
        {
            int aux = _bonus;
            _bonus = _points;
            return aux;
            
        }

        else{
        return base.GetPoints();
        }
    }

    public override string Save()
    {
        return $"{_name}|{base.Save()}|{_completion}|{_maxCompletion}|{_bonus}";
    }

    public override void Load(string title, string description, int points, bool checkbox)
    {
        base.Load(title, description, points, checkbox);
        
    }


}