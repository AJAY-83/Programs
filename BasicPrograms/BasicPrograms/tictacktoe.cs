

namespace BasicPrograms
{
using System;



public class TicTacToeTest  {
	static char[,] board=new char[3,3];
	
	public static void Display(char[,] board)
	{
	
		for(int i=0;i<3;i++)
		{
			
			for(int j=0;j<3;j++)
			{
				Console.Write(board[i,j]+ " {0} ");
			}
			Console.WriteLine();
		}
		
	}
	public static void repalce(char[,] matrix,char choice,char replace)
	{
		
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				if(matrix[i,j]==choice)
				{
					matrix[i,j]=replace;
					return;
				}
			}
			
		}
		
		
	}
	
	
	public static bool checkForWin()
	{
		
		return (checkRow() || checkColumn() || checkDiagonal());
		
	}
public static bool check(char c1,char c2,char c3)
{
	return ((c1==c2) && (c2==c3));
	
}
//check for row
	public static bool checkRow() {
		
		for(int i=0;i<3;i++)
		{
			if(check(board[i,0],board[i,1],board[i,2])==true)
			return true;
			
		}
		return false;
	}
	
	//check for coloum
public static bool checkColumn() {
		
		for(int i=0;i<3;i++)
		{
			
			if(check(board[0,i],board[1,i],board[2,i])==true)
			{
				return true;
			}
		}
		return false;
	}
//check for Diagonal
public static bool checkDiagonal() {
	
return((check(board[0,0],board[1,1],board[2,2])==true) || (check(board[0,2],board[1,1],board[2,0]))==true);
		
}



	public static void main(String[] args) {
	
		
		//give anotation to S for hiding purpose
	//	Scanner S=new Scanner(System.in);
		
		//Take player from user
		String Player1  ;
		Console.WriteLine("Enter player1 Name : ");
		Player1=Console.ReadLine();
		
		int end=0;
	//	Player2=S.nextLine();
		
		char Player1marker,Player2marker;
	   Console.WriteLine(Player1 +" : " +" select Marker symbol(X or O)");
		Player1marker=Convert.ToChar(Console.ReadLine());
        //Console.ReadLine();charAt(end);
		while(Player1marker !='X' && Player1marker !='x' && Player1marker !='O' && Player1marker!='o') 
		{
		
		 Console.WriteLine("Invalid input,Enter correct Marker symbol");
			Player1marker=Convert.ToChar(Console.ReadLine());
		
		}
		if(Player1marker=='X' || Player1marker =='x')
		{
			
			Player2marker='O';
			
		}
		else
		{
			Player2marker='X';
		}
		
		//Todisplay pattern of marix
		
	       int counter=0;
			for(int i=0;i<3;i++)
			{
				for(int j=0;j<3;j++)
				{
					board[i,j]=Char.forDigit(counter++,10);
                
				}
			}
			Display(board);
			
		//take user choice
			
		for(int i=0;i<4;i++)
		{
			
			 Console.WriteLine(Player1 +" "+" Turn :  = ");
             char  PChoice=Convert.ToChar(Console.ReadLine());			
		
               repalce(board, PChoice,Player1marker);
               Display(board);
               Console.WriteLine(" computer  turn : "); 
          
           	double k=(double) random.Next()*9;
		
           	int j=(int)k;
            Console.WriteLine(j);
			char choice=(char)(j+'0');
			 repalce(board,choice,Player2marker);
		     Display(board);
            Console.WriteLine();
		
//			if(choice==PChoice )
//			{
//	           	 k=(double) Math.random()*9;
//	         	 j=(int)k;
//				 System.out.println(j);
//			     choice=(char)(j+'0');
//			     repalce(board,choice,Player2marker);
//			   
//			     
//			     Display(board);
//			     System.out.println();
//			}
//			 else
//				{
//				   System.out.print(Player1 +"Turn :");
//			        choice=S.next().charAt(0);			
//					//Now were place the player choice with player selected marker
//			        repalce(board, choice,Player1marker);
//			         Display(board);
//				}
//			else if(PChoice==choice)
//				
//			{
//				
//				System.out.print(Player1 +" "+" Turn :  = ");
//	             PChoice=S.next().charAt(0);			
//				//Now were place the player choice with player selected marker
//	               repalce(board, PChoice,Player1marker);
//	               Display(board);
//	               System.out.println();
//			}
			/*else if(choice==PChoice)
			{

	           	 k=(double) Math.random()*9;
	         	 j=(int)k;
				 System.out.println(j);
			     choice=(char)(j+'0');
			     repalce(board,choice,Player2marker);
			   
			     
			     Display(board);
			     System.out.println();
				
				
			}*/
		  
        
         
		//Display(board);
			
		}
		//Upper loop will run 8 times but there are 9 position
	/*	System.out.print(Player1 +"Turn :");
        Choice=S.next().charAt(0);			
		//Now were place the player choice with player selected marker
        repalce(board, Choice,Player1marker);
         Display(board);
		*/
		
		
		
		
		
		
		
		
		//check winner
         if(checkForWin())
         {
        	 
        	            Console.WriteLine("we have winner");

         }
         else
         {
        	Console.WriteLine("There is tie");
         }
	}
 }
}