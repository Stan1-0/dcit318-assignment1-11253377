using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program allows users to check their grade");
        Console.WriteLine("----------************************------------");
        Console.Write("Please enter your score (0-100): ");
        
        
        string input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the letter grade
                Console.WriteLine($"The grade for your course is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
        }
    }
}
