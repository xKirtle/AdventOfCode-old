using System;
using System.IO;
using System.Text;

namespace AdventOfCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Challenges.Challenges.Day1();
        }
        
        public static string[] handleInput(int day)
        {
            string[] input;

            string path = Path.Combine(Environment.CurrentDirectory, $"Input\\Day{day}.txt");

            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                input = streamReader.ReadToEnd().Split(Environment.NewLine);

            return input;
        }
    }
}