using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Prompt{



    public string _prompt1;
    public string _prompt2;
    public string _prompt3;
    public string _prompt4;
    public string _prompt5;
    public string _prompt6;
    public string _prompt7;
    public string _prompt8;
    
    public string promptList;

    public static string Prompt.promptGenerator(){

        foreach (prompt in promptList()){
        Random rnd = new Random();
        int index = rnd.Next(promptList.Count);
        Console.WriteLine(promptGenerator[rnd.Next(_prompt1,_promt8)]);
        }
    }

}

class Journal{

public  List<Journal> journalEntries= new List<Journal>();
public string _journal;

public void Date()
{

DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToShortDateString();
}

public void Display()
    {
        Console.WriteLine($"{dateText}");
        Console.WriteLine($"{entry}");

       
        foreach (entry in _journal)
        {
            
            entry.Display();
        }
    }


}



class Program
{
    static void Main(string[] args)
    {
        //prompt user with a menu on what option to pick for the journal entry
        //create a list for the journal entries that will be randonly selected
        //create a file for the entries to be kept
        //write code so the date is listed for the journal entries

        //create the prompts for the random prompts generator
        Prompt p1= new Prompt()
        p1._prompt1="What is something unexpected that happened today?";
        Prompt p2= new Prompt();
        p2._prompt2= "List three things that you are grateful for.";
        Prompt p3= new Prompt();
        p3._prompt3 = "What is something you would want to do again from today?";
        Prompt p4= new Prompt();
        p4._prompt4= "Who was the most interesting person I interacted with today?";
        Prompt p5= new Prompt();
        p5._prompt5 = "What was the best part of my day?";
        Prompt p6= new Prompt();
        p6._prompt6 = "How did I see the hand of the Lord in my life today?";
        Prompt p7= new Prompt();
        p7._prompt7 = "What was the strongest emotion I felt today?";
        Prompt p8= new Prompt();
        p8._prompt8 = "If I had one thing I could do over today, what would it be?"; 

        //putting the different prompts into a list
        List<Prompt> promptList = new List<Prompt>();
        promptList.Add(p1);
        promptList.Add(p2);
        promptList.Add(p3);
        promptList.Add(p4);
        promptList.Add(p5);
        promptList.Add(p6);
        promptList.Add(p7);
        promptList.Add(p8);

        Random rnd = new Random();
        int index = rnd.Next(promptList.Count);
        Console.WriteLine(promptGenerator[rnd.Next(promptList))]);
        


        

        //menu for what to do
         Console.Write("Welcome to the Journal Program!");
         Console.Write("Please select one of the following choices:");
         Console.Write("1.Write");
         Console.Write("2.Display");
         Console.Write("3.Load");
         Console.Write("4.Save");
         Console.Write("5.Quit");
         Console.Write("What would you like to do?");
         string answer= Console.ReadLine();
         int selection = int.Parse(answer);

          List<Journal> journalEntries= new List<Journal>();



         if (selection== 1)
        {
            Console.Write(Prompt.promptGenerator());
            string journalEntry= Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            journalEntries.Add(journalEntry);


        }
        else if (selection ==2)
        {
            journalEntries.Display();
        }
        else if (selection ==3)
        {
           //load (?) 
        }
        else if (selection ==4)
        {
          //save jounral entries to a file
        public static void SaveToFile(List<journalEntries> entries){
        string fileName= "journalEntries.txt";

        using (StreamWriter outputFile= new StreamWriter(fileName)){
            foreach (journalEntries entries in journalEntries){
                outputFile.WriteLine(entries);

            }


        }
    }  
        }
        else
        {
           //end the program
           Console.Write("Have a great day!");
        }



       




    }


  

}
