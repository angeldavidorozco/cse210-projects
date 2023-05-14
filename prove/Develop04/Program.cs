using System;

class Program
{
    static void Main(string[] args)
    {
        int exit = 0;
        int decision = 0;
        int totalDuration = 0;
        int partialDuration = 0;
        while (exit == 0)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                
                    BreathingActivity Act0 = new BreathingActivity(0);

                    Act0.Intro();

                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(Act0.GetDuration());
        
                    while(DateTime.Now < endTime)
                    {

                        Act0.StartBreathing();

                    }

                    Act0.end(0);

                    totalDuration += Act0.GetDuration();

                    break;

                case 2:

                    ReflectingActivity Act1 = new ReflectingActivity(1);

                 

                    Random Rnd = new Random();

                    int i = Rnd.Next(3);

                    Act1.Intro();

                    Console.WriteLine($"{Act1.GetPromts()[i]}");

                    Console.Write("\n\nPress any key when you decide to continue ");
                    Console.ReadLine();

                    Console.WriteLine("\n");


                    DateTime startTime1 = DateTime.Now;
                    DateTime endTime1 = startTime1.AddSeconds(Act1.GetDuration());
        
                    while(DateTime.Now < endTime1)
                    {

                        Act1.StartReflecting();

                    }

                    Act1.end(1);

                    totalDuration += Act1.GetDuration();

                    break;

                case 3:

                    ListingActivity Act2 = new ListingActivity(2);

                    Act2.Intro();

                    Act2.Promtselection();

                    DateTime startTime2 = DateTime.Now;
                    DateTime endTime2 = startTime2.AddSeconds(Act2.GetDuration());
        
                    while(DateTime.Now < endTime2)
                    {

                        Act2.StartListing();

                    }

                    int items = Act2.listLeght();

                    Console.WriteLine($"You listed {items} items!");

                    Act2.end(2);

                    totalDuration += Act2.GetDuration();


                    break;



                case 4:
                
                    exit = 1;
                    Console.Clear();
                    Console.WriteLine($"Congratulation! you did a total of {totalDuration} seconds this session.");
                    break;


                default:
                
                    Console.WriteLine("Please enter a valid option.");
                    break;


            }


            
        }
    }
}