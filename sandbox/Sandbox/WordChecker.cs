using System;

public class WordChecker:Game
{
    private string[] _checkedScripture;
    //private string _scripturePlayed;


    public override void CheckWords(string[] scripture, string[] _fullScripture)
    {
        string _scriptureConstructor = "";

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

}