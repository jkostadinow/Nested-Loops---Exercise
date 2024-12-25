using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            int standard = 0;
            int kid = 0;

            string filmName = Console.ReadLine();

            while (filmName != "Finish")
            {
                int places = int.Parse(Console.ReadLine());
                int people = 0;

                for (int i = 0; i <= places; i++)
                {
                    string place = Console.ReadLine();

                    if (place == "student")
                    {
                        student++;
                    }
                    else if (place == "standard")
                    {
                        standard++;
                    }
                    else if (place == "kid")
                    {
                        kid++;
                    }
                    else if (place == "End")
                    {
                        break;
                    }
                    people++;
                }
                Console.WriteLine($"{filmName}-{filmName + people * 1.0 / places * 100}");
                filmName = Console.ReadLine();
            }
            int totalTickets = standard + student + kid;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student * 1.0 / totalTickets * 100:f2}% student tickets)");
            Console.WriteLine($"{standard * 1.0 / totalTickets * 100:f2}% standard tickets)");
            Console.WriteLine($"{kid * 1.0 / totalTickets * 100:f2}% kids tickets)");
        }
    }

}






