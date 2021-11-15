using System;
namespace XiangQi{
    class chariots:Chess{
        
    
     public chariots(){
     }
        public int Rule(int x1,int y1,int x2,int y2, int player,string[,] map){
           
            
            if(map[x1,y1]==" "){
                return 0;
            }
            
            if(x2==x1&&y2==y1){
                return 0;
            }
            
            if(player==0||player==1){
                
                if(x2==x1){
                for(int j=y1+1;j<y2;j++){
                    if(map[x2,j]!=" "){
                    return 0;
                }
                }
            }

               if(x2==x1){
                for(int j=y1-1;j>y2;j--){
                    if(map[x2,j]!=" "){
                    return 0;
                }
                }
            }

                if(y2==y1){
                for(int j=x1-1;j>x2;j--){
                    if(map[j,y2]!=" "){
                    return 0;
                }
                }    
            }   
                
                if(y2==y1){
                for(int j=x1+1;j<x2;j++){
                    if(map[j,y2]!=" "){
                    return 0;
                }
                }
            }

                if(x2!=x1&&y2!=y1){
                     return 0;
                }

            }
            return 1;
        }
        
    }
}