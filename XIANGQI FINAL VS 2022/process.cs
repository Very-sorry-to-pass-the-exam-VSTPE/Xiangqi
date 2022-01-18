using System;
namespace XiangQi
{
    class process
    {
        string[,] now = null;
        Chess c = new Chess();  //需要用到chess类和moverule和chessboard类
        moveRule m = new moveRule();
        ChessBoard chessboard = new ChessBoard();
        public process()
        {
            now = chessboard.Initialization();
            chessboard.display(now);
            Playing(now);

        }
        public void Playing(string[,] map)
        {
            int player = 0;
            int x1, y1, x2, y2;
            string TheOriginalXcoordinate;
            string TheOriginalYcoordinate;
            string TheLastXcoordinate;
            string TheLastYcoordinate;
            int gaming = 1;
            int moveflag;
            int t = 0; // turns



            while (gaming == 1)
            {
                if (player == 0)
                {
                    Console.WriteLine("RED side, please enter the position of the piece to be moved :");
                    Console.WriteLine("RED side, please enter the position for the piece is to reach :");
                }
                else if (player == 1)
                {
                    Console.WriteLine("BLACK side, please enter the position of the piece to be moved :");
                    Console.WriteLine("BLACK side, please enter the position for the piece is to reach :");
                }

                Console.Write("x1:");
                TheOriginalXcoordinate = Console.ReadLine();
                x1 = Convert.ToInt32(TheOriginalXcoordinate);
                Console.Write("y1:");
                TheOriginalYcoordinate = Console.ReadLine();
                y1 = Convert.ToInt32(TheOriginalYcoordinate);

                Console.Write("x2:");
                TheLastXcoordinate = Console.ReadLine();
                x2 = Convert.ToInt32(TheLastXcoordinate);
                Console.Write("y2:");
                TheLastYcoordinate = Console.ReadLine();
                y2 = Convert.ToInt32(TheLastYcoordinate);

                moveflag = m.Rule(x1, y1, x2, y2, player, map);

                if (moveflag == 1)
                {
                    c.move(x1, y1, x2, y2, map);
                    chessboard.display(map);
                    t++;
                }
                else if (moveflag != 1)
                {
                    Console.Write("Your action is invald. Please enter again.\n");
                }

                if (t % 2 == 0)
                {
                    player = 0;

                }
                else if (t % 2 != 0)
                {
                    player = 1;
                }


                int CheckmateRed = 0, CheckmateBlack = 0;
                for (int a = 0; a < 10; a++)
                {
                    for (int b = 0; b < 9; b++)
                    {
                        if (map[a, b] == "帅")
                        {
                            CheckmateRed = 1;
                        }
                        else if (map[a, b] == "将")
                        {
                            CheckmateBlack = 1;
                        }
                    }
                }
                if (CheckmateRed == 0)
                {
                    gaming = 0;
                    Console.Write("BLACK side win!");
                }
                else if (CheckmateBlack == 0)
                {
                    gaming = 0;
                    Console.Write("RED side win!");
                }
                else
                {
                    gaming = 1;
                }
            }
        }
    }
}