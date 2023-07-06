﻿using System;

// using App1.Part_2.Games.ManticoreHunt;
using App1.Part_2.Progi;
namespace App1.Part_2;

class PartTwo {
    public void Selection() {
        string[] apps = new string[7]{ "Grid Protect", "Even Or Odd", "Inventory", "Replicator", "Taking Number", "Countdown", "Hunting Manticore"};
        int index = 1;
        Console.WriteLine("Part 2.");
        Console.WriteLine("");
         foreach (var item in apps)
        {
            Console.WriteLine($"Item {index}: {item}");
            index++;
        }
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
                Console.WriteLine("PartTwo - App 2 - Chest Simulator");
                SimulasTest.Init();
                break;
            
            case 3:
                Console.WriteLine("PartTwo - App 2 - Tuples");
                Tuples.Init();
                break;
                
            default:
                Console.WriteLine("PartTwo - Exiting...");
                break;
        } 
    }
}
