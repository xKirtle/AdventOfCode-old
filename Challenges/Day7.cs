namespace AdventOfCode.Challenges;

public partial class Challenges
{
    public static void Day7()
    {
        D7P1();
        D7P2();
    }

    private static void D7P1()
    {
        string[] strInput = Program.handleInput(7);
        int[] positions = Array.ConvertAll(strInput[0].Split(","), str => int.Parse(str));
        Array.Sort(positions);
        
        int medianValue = positions[(positions.Length / 2) - 1];
        int fuelCost = 0;
        for (int i = 0; i < positions.Length; i++)
            fuelCost += Math.Abs(positions[i] - medianValue);

        Console.WriteLine("D7P1: " + fuelCost);
    }
    
    private static void D7P2()
    {
        string[] strInput = Program.handleInput(7);
        int[] positions = Array.ConvertAll(strInput[0].Split(","), str => int.Parse(str));
        int meanValue = (int)Math.Floor(positions.Average()); 
        //Should add a check whether floor or ceiling since our mean value is within 0.5 from the best position
        
        int fuelCost = 0;
        for (int i = 0; i < positions.Length; i++)
            fuelCost += Summation(Math.Abs(positions[i] - meanValue));

        Console.WriteLine("D7P2: " + fuelCost);
    }

    private static int Summation(int f) => f == 0 ? 0 : f + Summation(f - 1); //equals to n * (n+1) / 2
}