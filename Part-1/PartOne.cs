﻿using System;
using App1.Part_1.Progi;
using App1.Part_1.Games.ManticoreHunt;
namespace App1.Part_1;

class PartOne {
    public void Selection() {
        string[] apps = new string[8]{ "Grid Protect", "Even Or Odd", "Inventory", "Replicator", "Taking Number", "MagicCannon", "Countdown", "Hunting Manticore"};
        int index = 1;
        Console.WriteLine("Part 1.");
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
                Console.WriteLine("PartOne - App 1");
                GridProtect.Init();
                break;
            
            case 2:
                Console.WriteLine("PartOne - App 2");
                EvenOrOdd.Init();
                break;
                
            case 3:
                Console.WriteLine("PartOne - App 3");
                BuyingInventory.Init();
                break;
            case 4:
                Console.WriteLine("PartOne - App 4");
                ReplicatorOfDto.Init();
                break;
            case 5:
                Console.WriteLine("PartOne - App 5");
                TakingANumber.Start();
                break;
            case 6:
                Console.WriteLine("PartOne - App 6");
                Countdown.Init();
                break;
            case 7:
                Console.WriteLine("PartOne - App 7");
                MagicCannon.Init();
                break;
            case 8:
                Console.WriteLine("PartOne - App 8");
                HuntingManticore.Init();
                break;
                
            default:
                Console.WriteLine("PartOne - Exiting...");
                break;
        } 
    }
}
