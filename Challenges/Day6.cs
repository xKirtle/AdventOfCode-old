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

            for (int k = 0; k < 80; k++)
            {
                for (int i = 0; i < fishAges.Count; i++)
                    fishAges[i]--;

                int agedFishCount = fishAges.Count(x => x < 0);
                for (int i = 0; i < fishAges.Count; i++)
                    fishAges[i] = fishAges[i] < 0 ? 6 : fishAges[i];
                
                fishAges.AddRange(Enumerable.Repeat<int>(8, agedFishCount));
            }

            Console.WriteLine("D6P1: " + fishAges.Count);
        }

        private static void D6P2()
        {
            string[] strInput = Program.handleInput(6);
            List<int> fishAges = Array.ConvertAll(strInput[0].Split(","), int.Parse).ToList();

            long[] daily = new long[7];
            foreach (int age in fishAges)
                daily[age]++;

            long[] nextCycle = new long[7];
            long count = fishAges.Count;

            for (int day = 0; day < 256; day++)
            {
                int i = day % 7;
                long currentDay = daily[i];
                nextCycle[(i + 2) % 7] += currentDay;
                count += currentDay;

                daily[i] += nextCycle[i];
                nextCycle[i] = 0;
            }
            
            
            Console.WriteLine("D6P2: " + count);
        }
    }
}