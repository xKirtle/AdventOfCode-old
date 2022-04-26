using System.Text;

namespace AdventOfCode.Challenges;

public partial class Challenges
{
    public static void Day8()
    {
        D8P1();
        D8P2();
    }

    private static void D8P1()
    {
        string[] strInput = Program.handleInput(8);

        int result = 0;
        foreach (string s in strInput)
        {
            string[] output = s.Split(" | ")[1].Split(" ");
            for (int i = 0; i < output.Length; i++)
            {
                switch (output[i].Length)
                {
                    case 2:
                    case 4:
                    case 3:
                    case 7:
                        result++;
                        break;
                    default:
                        break;
                }
            }
        }

        Console.WriteLine("D8P1: " + result);
    }

    private static void D8P2()
    {
        string[] strInput = Program.handleInput(8);

        int result = 0;
        foreach (string s in strInput)
        {
            string[] str = s.Split(" | ");
            List<string> rules = str[0].Split(" ").ToList();
            // ruleSet.ForEach(x => x = new string(x.OrderBy(c => c).ToArray()));
            
            List<string> ruleSet = new List<string>();
            for (int i = 0; i < rules.Count; i++)
            {
                char[] arr = rules[i].ToArray();
                Array.Sort(arr);
                ruleSet.Add(new string(arr));
            }


            //Find segment scheme
            string[] segmentLetters = new string[7];

            string one = ruleSet.First(x => x.Length == 2);
            string four = ruleSet.First(x => x.Length == 4);
            string seven = ruleSet.First(x => x.Length == 3);
            string eight = ruleSet.First(x => x.Length == 7);
            ruleSet.RemoveAll(x => x == one || x == four || x == seven || x == eight);

            string three = ruleSet.First(x => x.Length == 5 && x.Contains(one));
            string nine = ruleSet.First(x => x.Length == 6 && x.Contains(four));
            string zero = ruleSet.First(x => x.Length == 6 && x != nine && x.Contains(one));
            string six = ruleSet.First(x => x.Length == 6 && x != nine && !x.Contains(one));
            string two = ruleSet.First(x => x.Length == 5 && x != three && !six.Contains(x));
            string five = ruleSet.First(x => x.Length == 5 && x != three && six.Contains(x));


            System.Console.WriteLine($"{zero} {one} {two} {three} {four} {five} {six} {seven} {eight} {nine}");

            //Calculate output based on it
            string outputString = "";
            string[] output = str[1].Split(" ");
            for (int i = 0; i < output.Length; i++)
            {

            }

        }

        Console.WriteLine("D8P2: " + result);
    }
}