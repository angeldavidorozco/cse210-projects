using System;

public class WordHider:Game
{

    Random rnd = new Random();

    private string[] _wordsList;

    private string _scriptureLeft;

    private int _wordsHidden;

    public string GetScriptureLeft()
    {
 
        return _scriptureLeft;

    }

    private string[] SeparateScripture(string scripture)
    {
 
        _wordsList = scripture.Split(' ', '\n');
        if(_wordsList[_wordsList.Length - 1] == "")
        {
        Array.Resize(ref _wordsList, _wordsList.Length - 1);
        }
        return _wordsList;

    }

    public string[] HideWords(string scripture)
    {

        _wordsHidden = 0;
        _scriptureLeft = "";

       SeparateScripture(scripture);
       
        int prob = SetProbability();

        foreach (string word in _wordsList)
        {
            
            int chance = rnd.Next(10);

            string changedWord = "___";
            
            if (word == "")
            {
                _scriptureLeft = _scriptureLeft + "\n\n";
            }

            else if ((char.IsNumber(word[0])))
            {
                _scriptureLeft += "\n\n" + word;
            }

            else if ((chance <= prob)&(word!="___"))
            {
                _scriptureLeft += " " + changedWord;
                _wordsHidden++;

            }

            else
            {
                _scriptureLeft = _scriptureLeft + " " + word;
            }
           
            
        }

        char[] separators = new char[] { ' ', '\n' };

        string[] subs = _scriptureLeft.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        return subs;

        //return (_scriptureLeft.Split(" "));

       
    }

    public int WordsHidden()
    {
        return _wordsHidden;
    }

    public int SetProbability()
    {
        if(_difficulty == 1)
        {
            return 2;
        }
        else if(_difficulty == 2)
        {
            return 4;
        }
        else
        {
            return 8;
        }
    }

    


}