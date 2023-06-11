using System;

// using App1.Part_2.Games.ManticoreHunt;
namespace App1.Part_2;

class PartTwo {
    public void Selection() {
        string[] apps = new string[7]{ "Grid Protect", "Even Or Odd", "Inventory", "Replicator", "Taking Number", "Countdown", "Hunting Manticore"};
        Console.WriteLine("Part 1.");
        Console.WriteLine("");
        Console.WriteLine("Enter Number: .. ");
        Console.WriteLine("\n ");
        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("PartTwo - App 1");
                break;
            
            case 2:
                Console.WriteLine("PartTwo - App 2");
                break;
                
            default:
                Console.WriteLine("PartTwo - Exiting...");
                break;
        } 
    }
}
