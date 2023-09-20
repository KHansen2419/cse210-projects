using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while(guess!=magic_number){

       // Console.Write("What is the magic number?")
        //string answer= Console.ReadLine();
        //int magic_number = int.Parse(answer);

        Console.Write("What is your guess?")
        guess = int.Parse(Console.ReadLine());

         if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
        else {
            Console.WriteLine("You guessed it!")
        }
        }
    }
}