using System;
using App1.Helpers;

// using App1.Part_2.Games.ManticoreHunt;
using App1.Part_2.Progi;
using App1.Part_2.Games;
namespace App1.Part_2;

class PartTwo {
    public void Selection() {
        Console.Clear();

        string[] apps = new string[]{ "Colored Console Solstice", "Simula Test","Tuples", "SimulaSoup", "Arrow", "GetterSetter", "AsteroidsGame"};
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
                
            case 4:
                Console.WriteLine("PartTwo - App 2 - Soup");
                SimulasSoup.Init();
                break;

            case 5:
                Console.WriteLine("PartTwo - Game 2 - Arrow");
                Archery archery = new Archery();
                Arrow arrow = archery.BuyArrow();
                arrow.GetCost();
                break;
            
            case 6:
                Console.WriteLine("PartTwo - App 2 - GetterSetter");
                GetterSetter gs = new GetterSetter();
                break;  

            case 7:
                Console.WriteLine("PartTwo - Game 2 - AsteroidsGame");
                AsteroidsGame game = new AsteroidsGame();
                game.Run();
                break;

            case 8:
                Console.WriteLine("PartTwo - Game 2 - TicTacToe");
                TicTacToe ttt1 = new TicTacToe();
                break;

            default:
                Console.WriteLine("PartTwo - Exiting...");
                break;
        } 
    }
}
