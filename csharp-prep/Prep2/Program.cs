using System;

class Program
{
    static void Main(string[] args)
    {

       Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();
        
        int number = int.Parse(value);

        string letter = "";


        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
           letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");


        if (number >= 70)
        {
            Console.WriteLine("Congratulations!!!");
        }
        else
        {
            Console.WriteLine("Try it next time, you can do it!");
        }

    }
}