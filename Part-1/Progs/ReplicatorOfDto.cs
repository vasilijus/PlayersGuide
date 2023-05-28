using System;

namespace App1.Part_1.Progi;
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
        int[][] matrix = new int[3][];
        matrix[0] = new int[] {1,2};
        Console.WriteLine();
        Console.WriteLine(matrix[0][1]);

        int[,] box = new int[4,4];
        for (int row = 0; row < box.GetLength(0); row++)
        {
            for (int col = 0; col < box.GetLength(1); col++)
            {
                Console.Write( box[row,col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(matrix[0][1]);
    }
}