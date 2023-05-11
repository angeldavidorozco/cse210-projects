using System;

public class MathAssingment : Assignment
{

   private string _textbookSection;
   private string _problems;

   public MathAssingment(string name, string topic, string textbook, string problems) : base(name, topic)
   {


    _textbookSection = textbook;
    _problems = problems;

   }

   public string GetHomeworkList()
   {

    return $"Section {_textbookSection} Problems {_problems}";

   }

}