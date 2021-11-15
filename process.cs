using System;
namespace XiangQi{
    class process{
        string[,] now=null;
    Chess c = new Chess();
    moveRule m=new moveRule();
    ChessBoard chess = new ChessBoard();
     public process(){
        now=chess.Initialization();
        chess.display(now);
        Playing(now);
 
     }
        public void Playing(string[,] map){
                    int player=0;
                    int x1, y1, x2, y2;
                    string q;
                    string w;
                    string e;
                    string r;
                    int gaming=1;
                    int moveflag;
                    int t=0; // turns
                    
               

                    while(gaming==1){
                    if(player==0){
                    Console.WriteLine("RED side, please enter the position of the piece to be moved :");
                    Console.WriteLine("RED side, please enter the positionfor the piece is to reach :");
                    }
                    else if(player==1){
                    Console.WriteLine("BLACK side, please enter the position of the piece to be moved :");
                    Console.WriteLine("BLACK side, please enter the position for the piece is to reach :");
                    }
                    
                    Console.Write("x1:");
                    q=Console.ReadLine();
                    x1=Convert.ToInt32(q);
                    Console.Write("y1:");
                    w=Console.ReadLine();
                    y1=Convert.ToInt32(w);
                    
                    Console.Write("x2:");
                    e=Console.ReadLine();
                    x2=Convert.ToInt32(e);
                    Console.Write("y2:");
                    r=Console.ReadLine();
                    y2=Convert.ToInt32(r);

                    moveflag=m.Rule(x1,y1,x2,y2,player,map);
                    
                    if(moveflag==1){
                    c.move(x1,y1,x2,y2,map);
                    chess.display(map);
                    t++;
                    }else if(moveflag!=1){
                    Console.Write("Your piece can't move to this position. Please enter again.\n");
                    }
                    
                    if(t%2==0){
                        player = 0;
                    
                    }else if(t%2 !=0){
                        player = 1;
                    }

                    
                    int jiangshuai=0,jiangjun=0; 
                    for(int a=0;a<10;a++){ 
                    for(int b=0;b<9;b++){
                        if(map[a,b] =="帅"){
                            jiangshuai=1;
                            }  
                        else if(map[a,b] =="将"){
                            jiangjun=1;
                            }
                }
                    }
                    if(jiangshuai==0){
                      gaming=0;
                      Console.Write("BLACK side win!");
                    }   
                    else if(jiangjun==0) {
                       gaming=0;
                      Console.Write("RED side win!");
                    } 
                    else{
                        gaming=1;
                    }
    }
}
}
}