using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");

        (string name, string topic) student;

        student = assignment.GetSummary();

        Console.WriteLine($"{student.name} - {student.topic}");

        MathAssingment math = new MathAssingment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        (string name, string topic) student2;

        student2 = math.GetSummary();

        string mathInfo = math.GetHomeworkList();

        Console.WriteLine($"{student2.name} - {student2.topic}");
        Console.WriteLine(mathInfo);

        
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        
        (string name, string topic) student3;

        student3 = writing.GetSummary();

        string writingInfo = writing.GetWritingInformation();

        Console.WriteLine($"{student3.name} - {student3.topic}");
        Console.WriteLine(writingInfo);

    }
}