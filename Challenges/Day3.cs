using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Challenges
{
    public partial class Challenges
    {
        public static void Day3()
        {
            D3P1();
            D3P2();
        }

        private static void D3P1()
        {
            string[] strInput = Program.handleInput(3);
            
            string gamma = "";
            string epsilon = "";
            for (int i = 0; i < strInput[0].Length; i++)
            {
                int zeroCounter = 0;
                int oneCounter = 0;
                
                foreach (string str in strInput)
                    _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                gamma += zeroCounter > oneCounter ? "0" : "1";
                epsilon += zeroCounter > oneCounter ? "1" : "0";
            }
            
            Console.WriteLine("D3P1: " + Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));
        }

        private static void D3P2()
        {
            //life support rating = oxygen rating * CO2 rating
            
            string[] strInput = Program.handleInput(3);
            //Most commong, 1>0
            List<string> o = strInput.ToList();
            //Least common, 0>1
            List<string> c = strInput.ToList();

            for (int i = 0; i < strInput[0].Length; i++)
            {
                if (o.Count != 1)
                {
                    int zeroCounter = 0;
                    int oneCounter = 0;
                    foreach (string str in o)
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                    char oType = (zeroCounter == oneCounter || oneCounter > zeroCounter) ? '1' : '0';
                    foreach (string str in o.ToList())
                    {
                        if (str[i] != oType)
                            o.Remove(str);
                    }
                }

                if (c.Count != 1)
                {
                    int zeroCounter = 0;
                    int oneCounter = 0;
                    foreach (string str in c)
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                    char cType = (zeroCounter == oneCounter || oneCounter > zeroCounter) ? '0' : '1';
                    foreach (string str in c.ToList())
                    {
                        if (str[i] != cType)
                            c.Remove(str);
                    }
                }

                if (o.Count == 1 && c.Count == 1)
                    break;
            }

            Console.WriteLine("D3P2: " + Convert.ToInt32(o[0], 2) * Convert.ToInt32(c[0], 2));
        }
    }
}