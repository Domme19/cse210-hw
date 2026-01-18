using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        int lastDigit = percent % 10;

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";

            if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        else if (percent >= 80)
        {
            letter = "B";
            if (lastDigit >= 7)
            {
                letter += "+";
            }
            
            if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        else if (percent >= 70)
        {
            letter = "C";
            if (lastDigit >= 7)
            {
                letter += "+";
            }
            
            if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        else if (percent >= 60)
        {
            letter = "D";
            if (lastDigit >= 7)
            {
                letter += "+";
            }
            
            if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        else
        {
            letter = "F";
            if (lastDigit < 3)
            {
                letter += "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}