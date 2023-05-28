using System;

namespace App1.Part_1.Progi;

class Countdown
{
    //<summary>
    //Level 13 - Reursive
    //</summary>
    public static void Init()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        AskForNumber(number);
    }

    public static int AskForNumber(int text)
    {
        
        if (text == 0) {
            Console.WriteLine($"Current {text}. finished");
            return text;
        } else {
            Console.WriteLine($"Current {text}.");
            AskForNumber(text-1);
            return text;
        }
    }

}