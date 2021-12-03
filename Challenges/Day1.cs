using System;
using System.Linq;

namespace AdventOfCode.Challenges
{
    public partial class Challenges
    {
        public static void Day1()
        {
            Part1();
            Part2();
        }
        
        private static void Part1()
        {
            string[] strInput = Program.handleInput(1);
            //Could throw an exception on int.Parse
            int[] input = Array.ConvertAll(strInput, int.Parse);

            int increaseCounter = 0;
            int previousValue = input[0];
            
            foreach (int depth in input)
            {
                if (depth > previousValue)
                    increaseCounter++;
                previousValue = depth;
            }

            Console.WriteLine("D1P1: " + increaseCounter);
        }

        private static void Part2()
        {
            string[] strInput = Program.handleInput(1);
            //Could throw an exception on int.Parse
            int[] input = Array.ConvertAll(strInput, int.Parse);

            int increaseCounter = 0;
            int previousValue = input.Take(3).Sum();
            for (int i = 0; i < input.Length - 2; i++)
            {
                int value = input.Skip(i).Take(3).Sum();
                if (value > previousValue)
                    increaseCounter++;
                previousValue = value;
            }
            
            Console.WriteLine("D1P2: " + increaseCounter);
        }
    }
}