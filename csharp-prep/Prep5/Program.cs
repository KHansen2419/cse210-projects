using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

          DisplayMessage();

          string userName= PromptUserName();

          int userNumber= PromptUserNumber();

          int squaredNumber= SquareNumbers(userNumber);

          DisplayResult(userName, squaredNumber);
    }


    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ")
        string name= Console.ReadLine();
        return name;
    }

       static int PromptUserNumber()
    {
        Console.Write("Please enter your name: ")
        userNumbers = int.Parse(Console.ReadLine());
        return numbers;
    }

    static int SquareNumbers(int number)
    {
    int square = number * number;
    return square;
    }
    
    static void DisplayResult(string name, int square)
    {
           Console.WriteLine($"{name}, the square of your number is {square}");
    }

}