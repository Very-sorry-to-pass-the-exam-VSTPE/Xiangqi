using System;

namespace XiangQi
{
    class moveRule
    {
        Chess c = new Chess();
        cannons a = new cannons();
        chariots b = new chariots();
        elephants d = new elephants(); // 需要利用这些类
        general e = new general();
        guards f = new guards();
        horses g = new horses();
        soldiers h = new soldiers();
        public moveRule()
        {

        }
        public int Rule(int x1, int y1, int x2, int y2, int player, string[,] now)
        {

            string[,] play_side = null;
            play_side = c.playerside();
            for (int k = 0; k < 7; k++)
            {
                if (now[x2, y2] == play_side[player, k])
                { //chess类里
                    return 0;
                }
            }
            string chess_type = now[x1, y1];
            switch (chess_type)
            {

                case "车":
                case "車":
                    return b.Rule(x1, y1, x2, y2, player, now);

                case "马":
                case "馬":
                    return g.Rule(x1, y1, x2, y2, player, now);

                case "象":
                case "相":
                    return d.Rule(x1, y1, x2, y2, player, now);

                case "仕":
                case "士":
                    return f.Rule(x1, y1, x2, y2, player, now);

                case "帅":
                case "将":
                    return e.Rule(x1, y1, x2, y2, player, now);

                case "砲":
                case "炮":
                    return a.Rule(x1, y1, x2, y2, player, now);

                case "兵":
                case "卒":
                    return h.Rule(x1, y1, x2, y2, player, now);

            }
            return 1;
        }
    }
}
