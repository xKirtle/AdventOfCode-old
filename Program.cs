using System.Text;
using AdventOfCode.Challenges;

namespace AdventOfCode;

internal class Program
{
    public static void Main(string[] args)
        => Challenges2020.Day1();

    public static string[] handleInput(int year, int day) {
        string[] input = null;

        string path = Path.Combine(Environment.CurrentDirectory, $"Input\\{year}\\Day{day}.txt");

        using (StreamReader streamReader = new(path, Encoding.UTF8)) {
            string read = streamReader.ReadToEnd();
            
            // Why is this not working?
            // input = read.Split(Environment.NewLine);
            
            if (read.Contains("\r\n")) {
                input = read.Split("\r\n");
            }
            else if (read.Contains("\n")) {
                input = read.Split("\n");
            }
        }

        return input;
    }
}