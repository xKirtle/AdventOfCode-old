namespace AdventOfCode.Challenges;

public partial class Challenges
{
    public static void Day5()
    {
        D5P1();
        // D5P2();
    }

    private static void D5P1()
    {
        string[] strInput = Program.handleInput(5);
        const int maxSize = 1000; //Based on what I saw in the input
        int[] coverCount = new int[maxSize * maxSize];
        int result = 0;
        
        foreach (string str in strInput)
        {
            string[] coords = str.Split(" -> ");
            int x1 = int.Parse(coords[0].Split(",")[0]);
            int y1 = int.Parse(coords[0].Split(",")[1]);
            int x2 = int.Parse(coords[1].Split(",")[0]);
            int y2 = int.Parse(coords[1].Split(",")[1]);

            for (int k = 0; k < maxSize * maxSize; k++)
            {
                int x = k % maxSize;
                int y = k / maxSize;

                //Not horizontal or vertical
                if (x1 != x2 && y1 != y2) continue;
                
                bool horizontal = y1 == y2;
                if (horizontal && x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2) && y == y1)
                    coverCount[k]++;
                else if (!horizontal && y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2) && x == x1)
                    coverCount[k]++;
            }
        }
        
        for (int k = 0; k < maxSize * maxSize; k++)
            if (coverCount[k] >= 2) result++;

        Console.WriteLine(result);
    }

    private static void D5P2()
    {
        
    }
}