namespace AdventOfCode.Challenges;

public partial class Challenges2021
{
    public static void Day4() {
        D4P1();
        D4P2();
    }

    private static void D4P1() {
        string[] strInput = Program.handleInput(2021, 4);
        List<List<List<int>>> boards = generateBoards(strInput);
        int[] drawNumbers = Array.ConvertAll(strInput[0].Split(","), int.Parse);
        int[] drawCount = turnsToSolveBoards(boards, drawNumbers);

        int boardIndex = drawCount.ToList().IndexOf(drawCount.First(x => x == drawCount.Min()));
        int sum = boards[boardIndex].SelectMany(row => row).Where(value => value != -1).Sum();
        Console.WriteLine("D4P1: " + sum * drawNumbers[drawCount[boardIndex] - 1]);
    }

    private static void D4P2() {
        string[] strInput = Program.handleInput(2021, 4);
        List<List<List<int>>> boards = generateBoards(strInput);
        int[] drawNumbers = Array.ConvertAll(strInput[0].Split(","), int.Parse);
        int[] drawCount = turnsToSolveBoards(boards, drawNumbers);

        int boardIndex = drawCount.ToList().IndexOf(drawCount.First(x => x == drawCount.Max()));
        int sum = boards[boardIndex].SelectMany(row => row).Where(value => value != -1).Sum();
        Console.WriteLine("D4P2: " + sum * drawNumbers[drawCount[boardIndex] - 1]);
    }

    private static int[] turnsToSolveBoards(List<List<List<int>>> boards, int[] drawNumbers) {
        int[] drawCount = new int[boards.Count];
        for (int k = 0; k < drawCount.Length; k++) {
            List<List<int>> board = boards[k];
            foreach (int drawNumber in drawNumbers) {
                for (int i = 0; i < board.Count; i++)
                for (int j = 0; j < board[i].Count; j++)
                    board[i][j] = board[i][j] == drawNumber ? -1 : board[i][j];

                drawCount[k]++;
                if (boardHasWon(board))
                    break;
            }
        }

        return drawCount;
    }

    private static bool boardHasWon(List<List<int>> board) {
        //Horizontal
        bool rowBingo = true;
        for (int i = 0; i < board.Count; i++) {
            rowBingo = true;
            for (int j = 1; j < board[i].Count; j++) {
                if (board[i][j - 1] != board[i][j]) { rowBingo = false; }
            }

            if (rowBingo)
                return true;
        }

        //Vertical
        bool columnBingo = true;
        for (int i = 0; i < board.Count; i++) {
            columnBingo = true;
            for (int j = 1; j < board[i].Count; j++) {
                if (board[j - 1][i] != board[j][i]) { columnBingo = false; }
            }

            if (columnBingo)
                return true;
        }

        return false;
    }

    private static List<List<List<int>>> generateBoards(string[] strInput) {
        List<List<List<int>>> boards = new((strInput.Length - 1) / 6);

        for (int i = 0; i < boards.Capacity; i++) {
            List<List<int>> board = new(5);
            int startIndex = i + 2 + 5 * i;

            for (int j = 0; j < board.Capacity; j++) {
                string[] rowString = strInput[startIndex + j].Replace("  ", " ").Trim().Split(" ");
                int[] row = Array.ConvertAll(rowString, int.Parse);
                board.Add(row.ToList());
            }

            boards.Add(board);
        }

        return boards;
    }
}