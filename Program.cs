using System;
using App1.Progi;
namespace App1;

class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Enter Number: .. ");
        Console.WriteLine("\n ");
        int selection = Convert.ToInt32(Console.ReadLine());

        if (selection == 1) 
        {
            GridProtect.Init();    
        } 
        else if(selection == 2) 
        {
            EvenOrOdd.Init();
        } 
        else 
        {
            Console.WriteLine("No ");
        }
    }
}
