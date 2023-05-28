using System;

namespace App1.Part_1.Progi;
class MagicCannon
{
    public static void Init() {

        // fire 3rd / electric 5th / potent combined blast
        int x = 0;
        while (x <= 100)
        {
            if (x % 5 == 0 && x % 3 == 0)
            {
                Console.WriteLine($"{x}: Potent Blast");
            } else if (x % 5 == 0)
            {
                Console.WriteLine($"{x}: Electric");
            } else if (x % 3 == 0)
            {
                Console.WriteLine($"{x}: Fire");
            } else 
            {
                Console.WriteLine($"{x}: Normal");
            }
            x++;
        }
    }
}