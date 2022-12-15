
using System;

namespace AdventOfCode.Y2022;

class SplashScreenImpl : SplashScreen {

    public void Show() {

        var color = Console.ForegroundColor;
        Write(0xcc00, false, "           ▄█▄ ▄▄█ ▄ ▄ ▄▄▄ ▄▄ ▄█▄  ▄▄▄ ▄█  ▄▄ ▄▄▄ ▄▄█ ▄▄▄\n           █▄█ █ █ █ █ █▄█ █ █ █   █ █ █▄ ");
            Write(0xcc00, false, " █  █ █ █ █ █▄█\n           █ █ █▄█ ▀▄▀ █▄▄ █ █ █▄  █▄█ █   █▄ █▄█ █▄█ █▄▄  /* 2022 */\n            \n ");
            Write(0xcc00, false, "          ");
            Write(0x333333, false, "##@@@####@@@###@@#@@@@@@@@#@@@@@@@@@@@##@#@@#@@@#  ");
            Write(0x666666, false, "25\n           ");
            Write(0x333333, false, "@@@@###@@#@@@@@@#@@@##@@@@@@#@@@@@@@#@@@#@@@@@@@@  ");
            Write(0x666666, false, "24\n           ");
            Write(0x333333, false, "@@@@@@#@#@#@@@@@##@@@##@@#@@##@#@@#@@@@@@#@@@@###  ");
            Write(0x666666, false, "23\n           ");
            Write(0x333333, false, "#@@@@@@@@@@@@#@@@@@@@@@@@@@@@@@##@@##@@@##@@#@@#@  ");
            Write(0x666666, false, "22\n           ");
            Write(0x333333, false, "@@@@@@@@##@@@@@@@####@@@@@#@@@@####@@##@@#@@@@##@  ");
            Write(0x666666, false, "21\n           ");
            Write(0x333333, false, "#@@#@#@@@#@@@@@####@@@@@#@@#########@@#@#@#@##@@#  ");
            Write(0x666666, false, "20\n           ");
            Write(0x333333, false, "@###@##@@@@@@@@###@@@@#@@@@@@##@@@@###@@@@@#@@#@@  ");
            Write(0x666666, false, "19\n           ");
            Write(0x333333, false, "@@@@@@@@@#@@####@@@###@@@###@#@@@@#@@@@@#@##@@@@@  ");
            Write(0x666666, false, "18\n           ");
            Write(0x333333, false, "@@@#@##@@@@@@#@@@#@#@@@@#@@@@#@@@#@@@@@#@@@#@@##@  ");
            Write(0x666666, false, "17\n           ");
            Write(0x333333, false, "#@@@##@##@#@@##@@@#@@@@#@#@@#@#@@@@#@#@#@@@###@##  ");
            Write(0x666666, false, "16\n           @#@@#@@#@@@@@@@@@@@#@@@@@#@@@#@@@@@@@@@@###@@@#@@  ");
            Write(0xcccccc, false, "15 ");
            Write(0x666666, false, "**\n           @@#@@@@@@@#@#@@#@@@#@@#@@@@#@#@@@###@@@@@#@@@@@##  ");
            Write(0xcccccc, false, "14 ");
            Write(0x666666, false, "**\n           #@@@@@@##@@#@@@@##@@@#@#@@##@@@#@@@@@@#@@#@@@##@#  ");
            Write(0xcccccc, false, "13 ");
            Write(0x666666, false, "**\n           @@#@@@@@@#@#@#@###@#@#@@@#@@#@@###@@@##@@@@@@#@#@  ");
            Write(0xcccccc, false, "12 ");
            Write(0x666666, false, "**\n           @@@@@@@#@@@@@@@##@@@@#@#@@@@@@@@@@@@##@@@@@@#@@@@  ");
            Write(0xcccccc, false, "11 ");
            Write(0x666666, false, "**\n           @####@#@@###@@@@@@@@@##@#@@@##|@###@@###@#@@#@@@@  ");
            Write(0xcccccc, false, "10 ");
            Write(0x666666, false, "**\n           #@@@@@@@@@@#@####@@@##@@@@@@@#@#@@@@@@#@@@@#@@@##  ");
            Write(0xcccccc, false, " 9 ");
            Write(0x666666, false, "**\n           ##@|@#@@@#@@@###@@#@@#@@@#@@@@@@@@#@#@#@@@#@@#@@@  ");
            Write(0xcccccc, false, " 8 ");
            Write(0x666666, false, "**\n           @@@@@#@@@@@#@#@#@#@@@#@@#@@@@@@@#@@#@##@@@@@@#@@#  ");
            Write(0xcccccc, false, " 7 ");
            Write(0x666666, false, "**\n           @@@@@@@@###@@@###@@#@@@###@#@@@@@@@#@@@#@@@@@@##@  ");
            Write(0xcccccc, false, " 6 ");
            Write(0x666666, false, "**\n           #@#@@#@@@@@#@@@@@@@@@@@@#@@@@@@@@#@#@@|@##@#@#@@#  ");
            Write(0xcccccc, false, " 5 ");
            Write(0x666666, false, "**\n           @@@@@#@@@#@@#@@@@##@#@@@@@#@@@@#@@@###@@@@#@@@@@@  ");
            Write(0xcccccc, false, " 4 ");
            Write(0x666666, false, "**\n           @@#@@#@@@##@@@@#@##@@@@@@@@@@@@@#@@@@#@@@@@@@@@@@  ");
            Write(0xcccccc, false, " 3 ");
            Write(0x666666, false, "**\n           @@@@@@@@@@@@@@@@#@@@#@@@@@#@@@@@@#@@@@@@@###@@@@@  ");
            Write(0xcccccc, false, " 2 ");
            Write(0x666666, false, "**\n           @@@@@#@@#@@@@@@@@@@@@@@#@@@@##@@#@@@@@@@@#@@@@@@@  ");
            Write(0xcccccc, false, " 1 ");
            Write(0x666666, false, "**\n           \n");
            
        Console.ForegroundColor = color;
        Console.WriteLine();
    }

   private static void Write(int rgb, bool bold, string text){
       Console.Write($"\u001b[38;2;{(rgb>>16)&255};{(rgb>>8)&255};{rgb&255}{(bold ? ";1" : "")}m{text}");
   }
}
