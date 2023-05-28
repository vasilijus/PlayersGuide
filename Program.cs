﻿using System;
using App1.Part_1;
using App1.Part_1.Progi;
using App1.Part_1.Games.ManticoreHunt;
namespace App1;

class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Enter Number: .. ");
        Console.WriteLine("\n ");
        Console.WriteLine("From 1-4 ");

        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("Part 1 - The Basics");
                PartOne p1Basics = new PartOne();
                p1Basics.Selection();
                break;
            
            case 2:
                Console.WriteLine("App 2");
                // EvenOrOdd.Init();
                break;
                
            case 3:
                Console.WriteLine("App 3");
                BuyingInventory.Init();
                break;
            case 4:
                Console.WriteLine("App 4");
                BuyingInventory.Init();
                break;
                
            default:
                Console.WriteLine("Exiting...");
                break;
        } 
    }
}
