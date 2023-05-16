using System;

namespace App1.Progi;
class ReplicatorOfDto
{
    public static void Init() {

        // fire 3rd / electric 5th / potent combined blast

        int[] nums = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            int input = Convert.ToInt32(Console.ReadLine());
            nums[i] = input;
        }
        int[] copynums = new int[5];


        for (int i = 0; i < nums.Length; i++)
        {
            copynums[i] = nums[i];
        }
        foreach(var item in copynums) {
            Console.Write($"{item}. ");
        }
    }
}