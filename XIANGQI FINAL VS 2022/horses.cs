using System;
namespace XiangQi
{
    class horses : Chess
    {



        public horses()
        {

        }
        public int Rule(int x1, int y1, int x2, int y2, int player, string[,] map)
        {


            if (player == 0 || player == 1)
            {

                if (x2 == x1 + 1)
                {
                    int j = y1 + 1;//  判断是否瘪马脚  [i,j]代表马脚位
                    int i = x1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }
                }

                if (x2 == x1 + 1)
                {
                    int j = y1 - 1;//  
                    int i = x1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }
                }

                if (x2 == x1 - 1)
                {
                    int j = y1 + 1;//  
                    int i = x1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }
                }

                if (x2 == x1 - 1)
                {
                    int j = y1 - 1;//  
                    int i = x1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }
                }

                if (x2 == x1 + 2)
                {
                    int j = y1;//  
                    int i = x1 + 1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }

                }

                if (x2 == x1 - 2)
                {
                    int j = y1;//  
                    int i = x1 - 1;
                    if (map[i, j] != " ")
                    {
                        return 0;
                    }
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