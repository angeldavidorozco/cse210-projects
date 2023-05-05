using System;

public class WordHider
{

    Random rnd = new Random();

    private string[] _wordsList;

    private string _scriptureLeft;

    public string GetScriptureLeft()
    {
 
        return _scriptureLeft;

    }

    public string[] SeparateScripture(string scripture)
    {
 
        _wordsList = scripture.Split(' ', '\n');
        if(_wordsList[_wordsList.Length - 1] == "")
        {
        Array.Resize(ref _wordsList, _wordsList.Length - 1);
        }
        return _wordsList;

    }

    public void HideWords()
    {


        _scriptureLeft = "";

       
       

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
                _scriptureLeft += word;
            }

            else if ((chance < 6)&(word!="___"))
            {
                _scriptureLeft += " " + changedWord;

            }

            else
            {
                _scriptureLeft = _scriptureLeft + " " + word;
            }
           
            
        }

        

    }


}