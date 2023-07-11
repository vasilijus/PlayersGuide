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
            
            case 9:
                Console.WriteLine("PartTwo - Game 2 - Cards");
                GenerateCards gcards = new GenerateCards();
                gcards.ShowCards();
                break;
            
            case 11:
                Console.WriteLine("PartTwo - Game 2 - List");
                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(11);
                numbers.Add(125);
                Console.WriteLine(numbers[1]);
                Console.WriteLine($"Position: {numbers.BinarySearch(125)}");
                break;
            case 12:
                Console.WriteLine("PartTwo - Game 2 - Cards");
                Door door = new Door(0000);
                int initialPasscode = GetInt("What will be the initial passcode?");
                int GetInt(string text) {
                    Console.Write($"{text} ");
                    return int.Parse(Console.ReadLine());
                }
                while(true)
                {
                    Console.Write($"The door is {door.DoorState}. What do you want to do? (open, close, lock, unlock, change code) ");
                    string command = Console.ReadLine();

                    switch(command)
                    {
                        case "open":
                            door.Open();
                            break;
                        case "close":
                            door.Close();
                            break;
                        case "lock":
                            door.Lock();
                            break;
                        case "unlock":
                            int guess = GetInt("What is the passcode?");
                            door.Unlock(guess);
                            break;
                        case "change code":
                            int currentCode = GetInt("What is the current passcode?");
                            int newCode = GetInt("What do you want to change it to?");
                            door.ChangeCode(currentCode, newCode);
                            break;
                    }
                }
                break;

            case 13:
                Console.WriteLine("PartTwo - Game 2 - Password validator");
                
                PassValidator pv1 = new PassValidator();
                bool b1 = pv1.IsValid("Pass1!");
                Console.WriteLine($"Password {b1}");
                PassValidator pv2 = new PassValidator();
                bool b2 = pv1.IsValid("Pass1");
                Console.WriteLine($"Password {b2}");
                break;
                
            case 14:
                Console.WriteLine("PartTwo - Game 2 - RockPaperScissor");
                RockPaperScissors rpc = new RockPaperScissors();
                rpc.Draw();
                break;

            default:
                Console.WriteLine("PartTwo - Exiting...");
                break;
        } 
    }
}
