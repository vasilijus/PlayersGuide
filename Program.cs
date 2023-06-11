using System;
using App1.Part_1;
using App1.Part_2;
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
                Console.WriteLine("Part 2 - OOP");
                PartTwo p2Advance = new PartTwo();
                p2Advance.Selection();
                break;
                
            case 3:
                Console.WriteLine("Part 3 - Advanced Topics");

                break;
            case 4:
                Console.WriteLine("Part 4 - The End Game");

                break;
                
            default:
                Console.WriteLine("Exiting...");
                break;
        } 
    }
}
