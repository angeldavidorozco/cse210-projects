using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class Scripture:Game
{

    //private string _scripture;
  
    protected string _wholeScript;
    private string _reference;
    private (int start, int end) _verse;

    public Scripture()
    {
        _verse.start = 1;
        _verse.end = 1;
        _reference = "1 Nephi 1";

    }

    public Scripture(string reference, string start, string end)
    {

        _verse.start = int.Parse(start);
        _verse.end = int.Parse(end);
        _reference = reference;

    }

    public string[] GetScripture()
    {
        return _scripture;
    }

    public string GetReference()
    {
        return _reference;
    }
    public (int, int) GetVerse()
    {
        return (_verse.start, _verse.end);
    }

    public override void Setscripture(string[] scripture)
    {

        _scripture = scripture;

    }

    public virtual void LoadScripture()
    {
        
    }

}