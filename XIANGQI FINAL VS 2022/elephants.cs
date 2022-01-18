using System;
namespace XiangQi
{
    class elephants : Chess
    {

        public elephants()
        {

        }
        public int Rule(int x1, int y1, int x2, int y2, int player, string[,] map)
        {
            // 象共4种移动方式(4 movements)
            // 双方的象都不能过河

            if (player == 0)
            {    //elephants in red side
                if (x2 > 4)
                {
                    return 0;
                }

                if (System.Math.Abs(x2 - x1) + System.Math.Abs(y2 - y1) != 4)
                {
                    return 0;
                }

                if (map[(x1 + x2) / 2, (y1 + y2) / 2] != " ")
                {
                    return 0;
                }
            }


            //////////////////////////////////////////////////////////////////////////////
            if (player == 1)
            {    //elephants in black side
                if (x2 < 5)
                {
                    return 0;
                }

                if (System.Math.Abs(x2 - x1) + System.Math.Abs(y2 - y1) != 4)
                {
                    return 0;
                }

                if (map[(x1 + x2) / 2, (y1 + y2) / 2] != " ")
                {
                    return 0;
                }
            }

            if (map[x1, y1] == " ")
            {
                return 0;
            }

            if (x2 == x1 && y2 == y1)
            {
                return 0;
            }

            return 1;
        }
    }
}