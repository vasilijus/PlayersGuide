﻿using System;
using App1.Part_1.Progi;
using App1.Part_1.Games.ManticoreHunt;
namespace App1;

class PartOne {
    public void Selection() {

        Console.WriteLine("Enter Number: .. ");
        Console.WriteLine("\n ");
        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("App 1");
                // GridProtect.Init();
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
            case 5:
                Console.WriteLine("App 5");
                // ReplicatorOfDto.Init();
                break;
            case 6:
                Console.WriteLine("App 6");
                TakingANumber.Start();
                break;
            case 7:
                Console.WriteLine("App 7");
                // Countdown.Init();
                break;
            case 8:
                Console.WriteLine("App 8");
                HuntingManticore.Init();
                break;
                
            default:
                Console.WriteLine("Exiting...");
                break;
        } 
    }
}
