using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        int token = 0;
        string exit = "n";

        CreateJournal Journal = new CreateJournal();

        do
        {

        

            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice) 
            {

                case "1":

                    token = 1;

                    WriteNewEntry Entry = new WriteNewEntry();

                    Entry.GeneratePromt();

                    Entry.GenerateEntry();

                    string entry = Entry._newEntry;

                    Journal._entries.Add(entry);


                    break;

                case "2":

                    Journal.DisplayJournal();

                    break;

                case "3":

                   

                    LoadJournal file = new LoadJournal();

                    Console.Write("What is the filename? ");

                    file._filename = Console.ReadLine();

                    file.Load();

                    Journal._entries.AddRange(file.SavedJournal._entries);
            
                    
                    break;
                    

                case "4":

                    token = 4;

                    string decision = "y";

                    SaveJournal Saving = new SaveJournal();

                    Console.Write("What is the filename? ");
                    
                    Saving._filename = Console.ReadLine();

                    

                    
                    if(File.Exists(Saving._filename))
                    {

                        Console.WriteLine("This file already exist");
                        Console.Write("Do you want to overwrite the file? y/n ");
                        decision = Console.ReadLine();
                        if(decision == "y")
                        {

                            Saving._newEntries = Journal._entries;
                            Saving.Save();

                        }
                        else
                        {
                            token = 1;
                        }

                    }

                    else
                    {

                        Saving._newEntries = Journal._entries;
                        Saving.Save();

                    }
                    
                    
                    break;

                case "5":

                    if(token == 1)
                    {

                        Console.Write("Do you want to leave without saving? (y/n) ");
                        exit = Console.ReadLine();
                        break;

                    }

                    Console.WriteLine("Goodbye!");
                    exit = "y";
                    break;

                default:

                    Console.WriteLine("Invalid choice!");
                    break;

            }
        }
        while(exit != "y");    

        
        
        

    }
}