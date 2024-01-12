using System;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage: ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string grade = "";

        if (number < 60)
        {
            grade = "F";
        }
        else if (number < 70)
        {
            grade = "D";
        }
        else if (number < 80)
        {
            grade = "C";
        }
        else if (number < 90)
        {
            grade = "B";
        }
        else
        {
            grade = "A";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}