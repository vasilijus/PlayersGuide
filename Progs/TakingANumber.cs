using System;

namespace App1.Progi;

class TakingANumber
{
    //<summary>
    //Level 13
    //</summary>
    public static void Start()
    {
        string text = "What is the airspeed velocity of an unladen swallow?";
        AskForNumber(text);
        AskForNumber(text, 5);
    }

    public static int AskForNumber(string text)
    {
        if( !String.IsNullOrWhiteSpace(text) ) Console.WriteLine(text);
        else Console.WriteLine("Enter an integer");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an integer");
        return number;
    }

    public static int AskForNumber(string text, int min)
    {
        if( !String.IsNullOrWhiteSpace(text) ) Console.WriteLine(text);
        else Console.WriteLine("Enter an integer");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Int min - {min}");
        return number;
    }
}