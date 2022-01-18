using System;
namespace XiangQi
{
    class ChessBoard
    {
        public ChessBoard()
        {

        }


        public string[,] Initialization()
        {
            string[,] map = new string[10, 9];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    map[i, j] = " ";
                }
            }


            map[0, 0] = "车";
            map[0, 1] = "马";
            map[0, 2] = "相";
            map[0, 3] = "仕";
            map[0, 4] = "帅";
            map[0, 5] = "仕";
            map[0, 6] = "相";
            map[0, 7] = "马";
            map[0, 8] = "车";
            map[2, 1] = "砲";
            map[2, 7] = "砲";
            map[3, 0] = "兵";
            map[3, 2] = "兵";
            map[3, 4] = "兵";
            map[3, 6] = "兵";
            map[3, 8] = "兵";

            map[9, 0] = "車";
            map[9, 1] = "馬";
            map[9, 2] = "象";
            map[9, 3] = "士";
            map[9, 4] = "将";
            map[9, 5] = "士";
            map[9, 6] = "象";
            map[9, 7] = "馬";
            map[9, 8] = "車";
            map[7, 1] = "炮";
            map[7, 7] = "炮";
            map[6, 0] = "卒";
            map[6, 2] = "卒";
            map[6, 4] = "卒";
            map[6, 6] = "卒";
            map[6, 8] = "卒";
            //chess in black side

            return map;   //将已完成初始化的数组传递出去
        }

        public void display(string[,] map)
        {


            for (int i = 0; i < 9; i++)
            {

                Console.Write(" " + i);

            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 9; j++)
                {


                    if (map[i, j] != " ")
                    {
                        Console.Write(map[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }


                }
                Console.Write("\n");
            }

        }
    }
}