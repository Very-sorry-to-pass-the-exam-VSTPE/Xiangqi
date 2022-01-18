using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 象棋.Rules;

namespace 象棋
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int turn = 0;
        public static int[,] map = new int[10, 9];

        public MainWindow()
        {
            InitializeComponent();

            piece[0] = Car_Red_1;
            piece[1] = Horse_Red_1;
            piece[2] = Elephant_Red_1;
            piece[3] = Warrior_Red_1;
            piece[4] = General_Red;
            piece[5] = Warrior_Red_2;
            piece[6] = Elephant_Red_2;
            piece[7] = Horse_Red_2;
            piece[8] = Car_Red_2;
            piece[9] = Canon_Red_1;
            piece[10] = Canon_Red_2;
            piece[11] = Soldier_Red_1;
            piece[12] = Soldier_Red_2;
            piece[13] = Soldier_Red_3;
            piece[14] = Soldier_Red_4;
            piece[15] = Soldier_Red_5;
            piece[16] = Car_Black_1;
            piece[17] = Horse_Black_1;
            piece[18] = Elephant_Black_1;
            piece[19] = Warrior_Black_1;
            piece[20] = General_Black;
            piece[21] = Warrior_Black_2;
            piece[22] = Elephant_Black_2;
            piece[23] = Horse_Black_2;
            piece[24] = Car_Black_2;
            piece[25] = Canon_Black_1;
            piece[26] = Canon_Black_2;
            piece[27] = Soldier_Black_1;
            piece[28] = Soldier_Black_2;
            piece[29] = Soldier_Black_3;
            piece[30] = Soldier_Black_4;
            piece[31] = Soldier_Black_5;
            Board.initialization(map);                                                    // initializate the entire virtual chessboard
        }

        public static Button[] piece = new Button[32];
        Button? first_choiced_piece = null;

        private void Grid_Click(object sender, MouseButtonEventArgs e)                   //when click happen, the action should be done
        {
            if (first_choiced_piece == null)
            {
                return;
            }
            else
            {
                Point p_end = e.GetPosition(this);                                       // get the address of click place

                p_end = Board.Point_To_Virtual(p_end);                                   // change this address into virtual address

                Point last_point = Board.Margin_To_Virtual(first_choiced_piece.Margin);  //turn then margin of button into virtual address

                int chesstype = Move.getbutton(first_choiced_piece);                     // to know which kinds of chess did you pick

                int camp = Move.side(chesstype);                                         // to know which side of the chess you pick
                int z = -1;
                if (camp == turn)                                                        // to check the turn of player
                {
                    if (Move.movePiece(chesstype, last_point, p_end, z, first_choiced_piece)) {  // move the piece by using the method from "Move" class
                        Move.Movemusic();
                        first_choiced_piece = null;
                        turn = Move.changeturn(turn);
                            }
                    else return;
                }
                else { first_choiced_piece = null; return; }
            }

        }
        private void choosePiece(object sender, RoutedEventArgs e)
        {

            Button second_choiced_piece = sender as Button;                                      //to seleted piece

            if (first_choiced_piece == null)
            {
                first_choiced_piece = second_choiced_piece;
            }

            else if (first_choiced_piece != second_choiced_piece)
            {
                Point last_point = Board.Margin_To_Virtual(first_choiced_piece.Margin);

                Point current_situation = Board.Margin_To_Virtual(second_choiced_piece.Margin);

                int chesstype = Move.getbutton(first_choiced_piece);                             //to find the emery
                int chesstype2 = Move.getbutton(second_choiced_piece);
                int z = Move.side(chesstype);
                int s_chesstype = Move.side(chesstype2);
                if (z == turn)
                {
                    if (Move.EatPiece(chesstype, chesstype2, last_point, current_situation, first_choiced_piece, second_choiced_piece))
                    {
                        ;  // to eat piece by using the method from "Move" class
                        Move.Eatmusic();
                        first_choiced_piece = null;
                        turn = Move.changeturn(turn);
                    }
                    else return;
                }

                else
                {
                    first_choiced_piece = null;
                    return;
                }
            }

        }





    }


}
