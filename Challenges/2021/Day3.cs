namespace AdventOfCode.Challenges;

public partial class Challenges2021
{
    public static void Day3() {
        D3P1();
        D3P2();
    }

    private static void D3P1() {
        string[] strInput = Program.handleInput(2021, 3);

        string gamma = "";
        string epsilon = "";
        for (int i = 0; i < strInput[0].Length; i++) {
            int zeroCounter = 0;
            int oneCounter = 0;

            foreach (string str in strInput)
                _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

            gamma += zeroCounter > oneCounter ? "0" : "1";
            epsilon += zeroCounter > oneCounter ? "1" : "0";
        }

        Console.WriteLine("D3P1: " + Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));
    }

    private static void D3P2() {
        string[] strInput = Program.handleInput(2021, 3);

        List<string> oxygen = someFunction(strInput.ToList(), (c1, c2) => c1 == c2 || c2 > c1 ? '1' : '0');
        List<string> co2 = someFunction(strInput.ToList(), (c1, c2) => c1 == c2 || c2 > c1 ? '0' : '1');

        List<string> someFunction(List<string> list, Func<int, int, char> func) {
            for (int i = 0; i < list[0].Length; i++) {
                if (list.Count != 1) {
                    int zeroCounter = 0;
                    int oneCounter = 0;
                    foreach (string str in list)
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                    char type = func(zeroCounter, oneCounter);
                    foreach (string str in list.ToList()) {
                        if (str[i] != type)
                            list.Remove(str);
                    }
                }
            }

            return list;
        }

        Console.WriteLine("D3P2: " + Convert.ToInt32(oxygen[0], 2) * Convert.ToInt32(co2[0], 2));
    }
}