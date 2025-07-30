using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("This program allows users to enter the value for the different sides of a triangle and determines what type of Triangle it is");
        Console.WriteLine("------------------------------************************-------------------------------------------------------------------------");

        Console.Write("Enter the value of the first side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of the second side: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of the third side: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(side1, side2, side3))
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isoceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
        } else
        { Console.WriteLine("The given sides do not form a triangle"); 
        }
    }

    private static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}