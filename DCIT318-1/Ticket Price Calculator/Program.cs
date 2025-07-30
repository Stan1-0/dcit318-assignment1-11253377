using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age >= 0)
        {
            decimal ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7m; //Discounted Price
            }
            else
            {
                ticketPrice = 10m; //Regular Price
            }

            Console.WriteLine($"Your ticket price is GHC{ticketPrice}");
        }
        else {
            Console.WriteLine("Invalid input.Please enter a valid age.");
        }
    }

}