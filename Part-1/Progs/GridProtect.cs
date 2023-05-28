using System;

namespace App1.Part_1.Progi;
class GridProtect
{
    public static void Init() {
    // See https://aka.ms/new-console-template for more information
        // ConsoleKeyInfo readK;
        // readK = Console.ReadKey();
        Console.BackgroundColor = ConsoleColor.Blue;
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.Beep();
        // Console.Beep(400,1000);

        string getSides(int a, int b) {
            var temp = "";
            temp += $"{a-1},{b}; {a},{b-1}; {a+1},{b}; {a},{b+1} ";
            return temp;
        }

        int valA = 0;
        int valB = 0;
        valA = Convert.ToInt32(Console.ReadLine());
        valB = Convert.ToInt32(Console.ReadLine());
        var items = getSides(valA, valB);

        Console.WriteLine($"Target {items}" );
    }
}