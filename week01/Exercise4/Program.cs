using System;

class Program
{
    static void Main(string[] args)
    {
        // exercise 4 
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            // Console.WriteLine($"The current number is: {number}");
            if (number != 0)
            {
                numbers.Add(number);
            }
           
        }

        // compute sum
        int total = 0;
        int largest = 0;
        int smallest = int.MaxValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
            int currentNumber = numbers[i];
            if (currentNumber > largest)
            {
                largest = currentNumber;
            }

            if (currentNumber > 0)
            {
                if (currentNumber < smallest)
                {
                    smallest = currentNumber;
                }
            }

        }

        float average = ((float)total / numbers.Count);
        // find the sorted list
        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The Smallest positive number is: {smallest}");

        // sortedList
        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{numbers[i]}");
        }



        
        
        
       

    }
}