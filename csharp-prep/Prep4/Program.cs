using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        do{
            Console. WriteLine("Enter a list of numbers, type 0 when finished.")
            Console.Write("Enter number: ")
            userNumbers = int.Parse(Console.ReadLine());

             if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];

            foreach (int number in numbers)
            {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        }while (new_numbers !=0);
    }
}