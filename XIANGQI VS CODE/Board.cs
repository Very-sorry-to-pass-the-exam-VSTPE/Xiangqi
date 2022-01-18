using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 象棋
{

    class Board
    {
       


        public static Point Point_To_Virtual(Point p) {            // turn true address into virtual address
            Point board = new Point(10, 9);

            for(int x = 0; x < 9; x++){
                if (p.X > x*83 && p.X <= (x+1)*83)
                {
                    board.Y = x;
                }
            }

            for (int y = 0; y < 10; y++){
                if (p.Y > y * 78 && p.Y <= (y + 1) * 78)
                {
                    board.X = y;
                }
            }

            return board;
            }

        public static Point Margin_To_Virtual(Thickness margin) {   //turn virtual address to virtual address
         Point point=new Point(10, 9);
            if (margin.Left < 738) point.Y = margin.Left / 83;
            if (margin.Top < 780) point.X = margin.Top / 78;

            return point;
        }

        public static Thickness Virtual_To_Margin(Point p)
        {
         Thickness margin = new Thickness();    
            margin.Top = 0;
            margin.Left = 0;
            if (p.X >= 0 && p.X <= 9) margin.Top = p.X*78;
            if (p.Y >= 0 && p.Y <= 10) margin.Left = p.Y * 83;

            return margin;
        }

        public static int[,] initialization(int[,] map)//the initialization of virtual chessboard
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    map[i, j] = -1;

                }
            }
            map[0, 0] = 0;
            map[0, 1] = 1;
            map[0, 2] = 2;
            map[0, 3] = 3;
            map[0, 4] = 4;
            map[0, 5] = 5;
            map[0, 6] = 6;
            map[0, 7] = 7;
            map[0, 8] = 8;
            map[2, 1] = 9;
            map[2, 7] = 10;
            map[3, 0] = 11;
            map[3, 2] = 12;
            map[3, 4] = 13;
            map[3, 6] = 14;
            map[3, 8] = 15;
            map[9, 0] = 16;
            map[9, 1] = 17;
            map[9, 2] = 18;
            map[9, 3] = 19;
            map[9, 4] = 20;
            map[9, 5] = 21;
            map[9, 6] = 22;
            map[9, 7] = 23;
            map[9, 8] = 24;
            map[7, 1] = 25;
            map[7, 7] = 26;
            map[6, 0] = 27;
            map[6, 2] = 28;
            map[6, 4] = 29;
            map[6, 6] = 30;
            map[6, 8] = 31;


            return map;   
        }

        public static void move(int x1,int y1,int x2,int y2, int[,] map){// to move the chess, both in real chessboard and virtual chessboard
        map[x2,y2]=map[x1,y1];
        map[x1,y1]=-1;
      }

    }


}
