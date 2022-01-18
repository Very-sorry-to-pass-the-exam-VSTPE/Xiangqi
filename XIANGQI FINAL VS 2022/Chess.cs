using System;
namespace XiangQi
{
    class Chess
    {



        public Chess()
        {

        }
        public string[,] playerside()
        {
            string[,] playerchess_type = new string[2, 7];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    playerchess_type[i, j] = " ";
                }
            }


            playerchess_type[0, 0] = "车";  //RED side --> row 1  player==0
            playerchess_type[0, 1] = "马";
            playerchess_type[0, 2] = "相";
            playerchess_type[0, 3] = "仕";
            playerchess_type[0, 4] = "帅";
            playerchess_type[0, 5] = "砲";
            playerchess_type[0, 6] = "兵";

            playerchess_type[1, 0] = "車";  //BLACK side --> row 1  player==0
            playerchess_type[1, 1] = "馬";
            playerchess_type[1, 2] = "象";
            playerchess_type[1, 3] = "士";
            playerchess_type[1, 4] = "将";
            playerchess_type[1, 5] = "炮";
            playerchess_type[1, 6] = "卒";


            return playerchess_type;
        }


        public void move(int x1, int y1, int x2, int y2, string[,] map)
        {
            map[x2, y2] = map[x1, y1];
            map[x1, y1] = " ";
        }
    }
}
