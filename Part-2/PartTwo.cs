﻿using System;

// using App1.Part_2.Games.ManticoreHunt;
namespace App1.Part_2;

class PartTwo {
    public void Selection() {
        string[] apps = new string[7]{ "Grid Protect", "Even Or Odd", "Inventory", "Replicator", "Taking Number", "Countdown", "Hunting Manticore"};
        Console.WriteLine("Part 2.");
        Console.WriteLine("");
        Console.WriteLine("Enter Number: .. ");
        Console.WriteLine("\n ");
        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("PartTwo - App 1");
                Season current = Season.Spring;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(current);
                if(current == Season.Spring || current == Season.Winter)
                    Console.WriteLine("Happy solstice!");
                else
                    Console.WriteLine("Happy equinox!");
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
