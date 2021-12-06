using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Challenges
{
    public partial class Challenges
    {
        public static void Day6()
        {
            D6P1();
            D6P2();
        }

        private static void D6P1()
        {
            string[] strInput = Program.handleInput(6);
            List<int> fishAges = Array.ConvertAll(strInput[0].Split(","), int.Parse).ToList();
            long count = simulateLanternfish(fishAges, 80);
            
            Console.WriteLine("D6P2: " + count);
        }

        private static void D6P2()
        {
            string[] strInput = Program.handleInput(6);
            List<int> fishAges = Array.ConvertAll(strInput[0].Split(","), int.Parse).ToList();
            long count = simulateLanternfish(fishAges, 256);
            
            Console.WriteLine("D6P2: " + count);
        }

        private static long simulateLanternfish(List<int> fishAges, int numDays)
        {
            long[] daily = new long[7];
            foreach (int age in fishAges)
                daily[age]++;

            long[] nextCycle = new long[7];
            long count = fishAges.Count;

            for (int day = 0; day < numDays; day++)
            {
                int i = day % 7;
                long currentDay = daily[i];
                nextCycle[(i + 2) % 7] += currentDay;
                count += currentDay;

                daily[i] += nextCycle[i];
                nextCycle[i] = 0;
            }

            return count;
        } 
    }
}