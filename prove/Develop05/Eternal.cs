using System;

public class Eternal : Goal
{
    private string _name = "Eternal Goal";

    private string _fullGoal;

    private string _listGoal;

    private int _completion;

    //public Eternal(string title, string description, int points, bool checkbox, string name): base( title,  description,  points,  checkbox)
    //{
    //    _name = name;
    //}

    public override string GetName()
    {
        return _name;
    }

    public void LoadEternal( int completion)
    {
        _completion = completion;
    }

        public override void SetGoal()
    {
        base.SetGoal();

        _fullGoal = $"{_name} ({_description})";

        _listGoal = $"{_title} ({_description}) -- Times completed: {_completion}";

    }

    public override string GetListGoal()
    {
        _listGoal = $"{_title} ({_description}) -- Times completed: {_completion}";

       
            return $"[ ] {_listGoal}";
        
    }

    

        public override void CheckCompletion()
    {
        _completion++;
    }

        public override int GetPoints()
    {
        return base.GetPoints();
    }

    public override string Save()
    {
        return $"{_name}|{base.Save()}|{_completion}";
    }

        public override void Load(string title, string description, int points, bool checkbox)
    {
        base.Load(title, description, points, checkbox);
        
    }


}