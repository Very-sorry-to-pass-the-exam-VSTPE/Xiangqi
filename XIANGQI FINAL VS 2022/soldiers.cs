using System;
namespace XiangQi
{
    class soldiers : Chess
    {



        public soldiers()
        {

        }
        public int Rule(int x1, int y1, int x2, int y2, int player, string[,] map)
        {

            if (map[x1, y1] == " ")
            {
                return 0;
            }

            if (x2 == x1 && y2 == y1)
            {
                return 0;
            }


            //player 0 = red side
            if (player == 0)
            {

                if (x2 < x1)
                {           //cannot back
                    return 0;
                }
                if (x1 < 5 && y2 != y1 || System.Math.Abs(x2 - x1) != 1)
                { //没过河
                    return 0;
                }
                if (x1 > 4 && System.Math.Abs(y2 - y1) + System.Math.Abs(x2 - x1) != 1)
                {  //过了河
                    return 0;
                }
            }

            //player 1 = black side   
            if (player == 1)
            {


                if (x2 > x1)
                {           //cannot back
                    return 0;
                }
                if (x1 > 4 && y2 != y1 || System.Math.Abs(x2 - x1) != 1)
                {
                    return 0;
                }
                if (x1 < 5 && System.Math.Abs(y2 - y1) + System.Math.Abs(x2 - x1) != 1)
                {
                    return 0;
                }
            }
            return 1;
        }

    }

}
