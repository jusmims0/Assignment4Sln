using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int average = 0;

            Console.WriteLine("enter your number");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter next number");
                nums[i] = int.Parse(Console.ReadLine());
                average = (nums[0] + nums[1] + nums[2] + nums[3] + nums[4]) / 5;
            }
            Console.WriteLine($"The answer is {average}");
        }
    }
}
