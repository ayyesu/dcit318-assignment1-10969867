using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
     class Customer
    {
        public int Age { get; set; }

        public Customer(int age)
        {
            Age = age;
        }

        public decimal GetTicketPrice()
        {
            if (Age >= 65 || Age <= 12)
            {
                return 7.00m;
            }
            else
            {
                return 10.00m;
            }
        }
    }
}
