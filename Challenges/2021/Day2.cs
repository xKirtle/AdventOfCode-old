namespace AdventOfCode.Challenges;

public partial class Challenges2021
{
    public static void Day2() {
        D2P1();
        D2P2();
    }

    private static void D2P1() {
        string[] strInput = Program.handleInput(2021, 2);

        int horizontalPos = 0;
        int depth = 0;

        foreach (string str in strInput) {
            string[] command = str.Split(" ");
            //Could throw an exception on int.Parse
            int value = int.Parse(command[1]);

            switch (command[0]) {
                case "forward":
                    horizontalPos += value;
                    break;
                case "down":
                    depth += value;
                    break;
                case "up":
                    depth -= value;
                    break;
            }
        }

        Console.WriteLine("D2P1: " + horizontalPos * depth);
    }

    private static void D2P2() {
        string[] strInput = Program.handleInput(2021, 2);

        int horizontalPos = 0;
        int depth = 0;
        int aim = 0;
        foreach (string str in strInput) {
            string[] command = str.Split(" ");
            //Could throw an exception on int.Parse
            int value = int.Parse(command[1]);

            switch (command[0]) {
                case "forward":
                    horizontalPos += value;
                    depth += aim * value;
                    break;
                case "down":
                    aim += value;
                    break;
                case "up":
                    aim -= value;
                    break;
            }
        }

        Console.WriteLine("D2P2: " + horizontalPos * depth);
    }
}