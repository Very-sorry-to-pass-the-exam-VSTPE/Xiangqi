using System;
namespace XiangQi
{
    class cannons : Chess
    {



        public cannons()
        {

        }
        public int Rule(int x1, int y1, int x2, int y2, int player, string[,] map)
        {
            int piecesinthemiddle = 0;

            if (player == 0 || player == 1)
            {

                if (x2 == x1)
                {
                    if (y1 < y2)
                    {
                        for (int j = y1 + 1; j < y2; j++)
                        {
                            if (map[x2, j] != " ")
                            {
                                piecesinthemiddle++;
                            }
                        }
                    }
                    else if (y1 > y2)
                    {
                        for (int j = y1 - 1; j > y2; j--)
                        {
                            if (map[x2, j] != " ")
                            {
                                piecesinthemiddle++;
                            }
                        }
                    }
                }

                else if (y2 == y1)
                {
                    if (x1 < x2)
                    {
                        for (int j = x1 + 1; j < x2; j++)
                        {
                            if (map[j, y2] != " ")
                            {
                                piecesinthemiddle++;
                            }
                        }
                    }
                    else if (x1 > x2)
                    {

                        for (int j = x1 - 1; j > x2; j--)
                        {
                            if (map[j, y2] != " ")
                            {
                                piecesinthemiddle++;
                            }
                        }
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

            if (piecesinthemiddle > 1)
            {
                piecesinthemiddle = 0;
                return 0;
            }
            else if (piecesinthemiddle == 1)
            {
                piecesinthemiddle = 0;
                if (map[x2, y2] == " ")
                {

                    return 0;
                }
                return 1;
            }
            else if (piecesinthemiddle == 0)
            {
                piecesinthemiddle = 0;
                if (map[x2, y2] != " ")
                {

                    return 0;
                }
                return 1;

            }
            piecesinthemiddle = 0;
            return 1;
        }

    }
}
