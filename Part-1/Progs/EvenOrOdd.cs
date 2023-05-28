using System;

namespace App1.Part_1.Progi;
class EvenOrOdd
{
    public static void Init() {

        Console.WriteLine("Insert a number from 1 - 100 ...");
        int number = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine($"Number: {number}");
        if (number % 2 == 0) {
            Console.WriteLine("Tick");
        }
        else {
            Console.WriteLine("Tock");
        }
    }
}