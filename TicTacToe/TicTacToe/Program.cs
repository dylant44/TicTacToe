using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicTacToe
{
    class MainClass
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Tic Tac Toe! Press ENTER to start\n\n\n ");
            ReadLine();

            displayGame();
        }





        public static void displayGame()
        {
            int count = 0;
            Boolean playing = true;
            Boolean x = true;
            MainClass tictoe = new MainClass();

            tictoe.displayTemplate();

            do
            {
                if (x)
                {
                    int num;
                    String tempString;
                    WriteLine("Player X, input a number");
                    tempString = ReadLine();
                    num = Convert.ToInt32(tempString);
                    tictoe.placePiece("X", num);

                    tictoe.displayMap();
                    count++;
                    x = false;
                }
                else
                {
                    int num;
                    String tempString;
                    WriteLine("Player O, input a number");
                    tempString = ReadLine();
                    num = Convert.ToInt32(tempString);
                    tictoe.placePiece("O", num);

                    tictoe.displayMap();

                    x = !x;
                    count++;
                }

                if (Win() != null)
                {

                    WriteLine((x ? "O" : "X") + " is the Winner!");
                    return;
                }
                else if (count == 9)
                {
                    WriteLine("TIE!");
                    ReadLine();
                    return;
                }


            } while (playing || count != 9);
        }



        static string[] board =
        {
            "0", "1", "2",
            "3", "4", "5",
            "6", "7", "8"
        };

        public void displayTemplate()
        {
            WriteLine(""
                + "\n0|1|2"
                + "\n------"
                + "\n3|4|5"
                + "\n------"
                + "\n6|7|8");
        }

        public void placePiece(String piece, int position)
        {
            board[position] = piece;
        }

        public static String Win()
        {
            for (int a = 0; a < 8; a++)
            {
                String line = null;
                switch (a)
                {
                    case 0:
                        line = board[0] + board[1] + board[2];
                        break;

                    case 1:
                        line = board[3] + board[4] + board[5];
                        break;
                    case 2:
                        line = board[6] + board[7] + board[8];
                        break;
                    case 3:
                        line = board[0] + board[3] + board[6];
                        break;
                    case 4:
                        line = board[1] + board[4] + board[7];
                        break;
                    case 5:
                        line = board[2] + board[5] + board[8];
                        break;
                    case 6:
                        line = board[0] + board[4] + board[8];
                        break;
                    case 7:
                        line = board[2] + board[4] + board[6];
                        break;
                    default:
                        line = "ERROR";
                        break;
                }

                if (line.Equals("XXX"))
                {
                    return "X";
                }
                else if (line.Equals("OOO"))
                {
                    return "O";
                }
            }
            return null;
        }

        public void displayMap()
        {

            WriteLine(""
                    + "\n" + board[0] + "|" + board[1] + "|" + board[2] + ""
                    + "\n-----"
                    + "\n" + board[3] + "|" + board[4] + "|" + board[5] + ""
                    + "\n-----"
                    + "\n" + board[6] + "|" + board[7] + "|" + board[8] + "");

        }
    }

}
