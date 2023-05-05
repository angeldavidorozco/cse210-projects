using System;

public class RefAndVerse
{

    private (int start, int end) _verse;

    private string _reference;

    /*private int _start;

    private int _end;*/
    public RefAndVerse()
    {
        _verse.start = 1;
        _verse.end = 1;
        _reference = "1 Nephi 1";

    }

    public RefAndVerse(string reference, int start)
    {

        _verse.start = start;
        _verse.end = start;
        _reference = reference;

    }

    public RefAndVerse(string reference, int start, int end)
    {

        _verse.start = start;
        _verse.end = end;
        _reference = reference;

    }

    public (int, int) GetVerse()
    {
        return (_verse.start, _verse.end);
    }

    public void SetVerse(int start)
    {

        _verse.start = start;
        _verse.end = start;


    }
    public void SetVerse(int start, int end)
    {

        _verse.start = start;
        _verse.end = end;

    }

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }


}