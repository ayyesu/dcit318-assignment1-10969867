using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Customer, How old are you? ");

            string input = Console.ReadLine();

            int numAge;

            if (int.TryParse(input, out numAge) && numAge > 0)
            {
                Customer customer = new Customer(numAge);

                decimal ticketPrice = customer.GetTicketPrice();

                Console.WriteLine($"Your Price for the ticket is GHC{ticketPrice}");

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input, Please provide the right age to process your ticket price");

                Console.ReadLine();
            }
        }
    }
}
