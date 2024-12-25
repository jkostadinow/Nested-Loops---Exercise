using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int free;
            int tickets;
            int kidTickets = 0;
            int studentTickets = 0;
            int standardTikets = 0;
            string type;
            while (input != "Finish")
            {
                free = int.Parse(Console.ReadLine());
                tickets = 0;
                type = Console.ReadLine();
                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTikets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    tickets++;
                    if (tickets >= free)
                    {
                        break;
                    }
                    type = Console.ReadLine();
                }
                Console.WriteLine($"{input} - {(double)tickets / free * 100:f2}% full.");
                input = Console.ReadLine();

            }
            int totalTickets = standardTikets + studentTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTikets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");

        }
    }
}
