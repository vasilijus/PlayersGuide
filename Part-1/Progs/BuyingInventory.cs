using System;

namespace App1.Part_1.Progi;
class BuyingInventory
{
    public static void Init() {

        Console.WriteLine(" \n1 - Rope, \n2 - Torches, \n3 - Climbing Equipment, \n4 - Clean Water, \n5 - Machete, \n6 - Canoe, \n7 - Food Supplies \n");
        Console.WriteLine("Enter the number to find the item price");
        int choice = Convert.ToInt32(Console.ReadLine());
        string response;

        response = choice switch
        {
            1 => "Rope: 10 gold",
            2 => "Torches: 15 gold",
            3 => "Climbing Equipment: 25 gold",
            4 => "Clean Water: 1 gold",
            5 => "Machete: 20 gold",
            6 => "Canoe: 200 gold",
            7 => "Food Supplies: 1 gold",            
            _ => "No info"
        };

        Console.WriteLine(response);
    }
}