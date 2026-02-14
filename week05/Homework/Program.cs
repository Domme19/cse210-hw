using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        // Testing of inheritance

        Assignment homework = new Assignment("Dieuveille Mabounda", "Multiplication");
        Console.WriteLine(homework.GetSummary()); 

        MathAssignment maths = new MathAssignment("Dieuveille Mabounda", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(maths.GetSummary());
        Console.WriteLine(maths.GetHomeWorkList());


        WritingAssignment essay = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation()); 

    

    }
}