using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());

            if(qty < 10)
            {
                discount = 5;
            } else if (qty < 50)
            {
                discount = 10;
            } else
            {
                discount = 20;
            }

            Console.WriteLine("Discount: {0}%", discount);
        }
    }
}
