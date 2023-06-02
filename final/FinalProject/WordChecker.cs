using System;

public class WordChecker:Game
{
    private string[] _checkedScripture;
    //private string _scripturePlayed;
    string _scriptureConstructor = "";

    public override void CheckWords(string[] scripture, string[] _fullScripture)
    {
        

        _checkedScripture = _fullScripture;
        

        int i = 0;

        foreach(string word in scripture)
        {

            if((word == "___"))
            {
                string input = Console.ReadLine();

                if(CheckInput(input,i))
                {
                    Console.Clear();
                    _scriptureConstructor += input + " " ;
                }
                else
                {
                    Console.Clear();
                   _scriptureConstructor += word + " " ;
                }

            }
            else if ((char.IsNumber(word[0])))
            {
                Console.Clear();
                _scriptureConstructor += "\n\n" + word + " " ;
            }
            else
            {
                Console.Clear();
                _scriptureConstructor += word + " " ; 
            }

            
            Console.Write($"{_scriptureConstructor}");

            i++;
        }


    }

    private bool CheckInput(string input, int index)
    {
        if(_checkedScripture[index] == input)
        {
            return true;
        }
        else
        {
            return false;
        }    
    }  

    public int CheckCorrect()
    {
        int counter = 0;
        string[]_playerWords = _scriptureConstructor.Split(" ");
        foreach (string word in _playerWords)
        {
            if (word == "___")
            {
                counter++;
            }
        }
        return counter;
    } 

}