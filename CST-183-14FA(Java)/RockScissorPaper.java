/****************************************
Created by: Nahtan Gaffney
24-Sep-2014
THis program will simulate rolling of dice.
The program will also display wins/ties.
CST-183-FA110-14FA-COURSE
*****************************************/
import javax.swing.JOptionPane;
import java.util.Random;
public class RockScissorPaper
{
 public static void main (String args[])
 {
  Random generator = new Random();
  boolean games =false, choices= false;
  String compChoices = "RSP";
  String input;
  char computerPick, playerPick ='o';//Choices
  int numberGames=0;       //# of games played
  int computerWins=0, playerWins =0; //# of wins
  int count=0;
  int game = 1;
  String playerHisto="";
  String compHisto="";
  
  while (games == false)
  {
  //Get number of games and then conver to int
   numberGames = Integer.parseInt(JOptionPane.showInputDialog("Enter number of games to play"
                                         + " between 1-8: "));
   if (numberGames >= 1&&numberGames <=8)
   
      {games = true;}
  }
  while (count<numberGames)
  {
   computerPick = compChoices.charAt(generator.nextInt(compChoices.length()));
   while (choices == false)
   {
     input = (JOptionPane.showInputDialog(
              "Game: "+game+
              ": Enter choice (R,S,or P)"));
     input = input.toUpperCase();
     playerPick = input.charAt(0);
     if (playerPick == 'R' //Check for valid Input
       ||playerPick == 'S' 
       ||playerPick == 'P')
     {choices = true;}
   }
   if (!(playerPick==computerPick))
   {
     if (playerPick=='R' && computerPick=='S')
     { playerWins++;
      JOptionPane.showMessageDialog(null,"Player Wins","Game: "+game,
                                    JOptionPane.INFORMATION_MESSAGE);
     }
     else if (playerPick=='S'&&computerPick=='P')
     { playerWins++;
       JOptionPane.showMessageDialog(null,"Player Wins","Game: "+game,
                                     JOptionPane.INFORMATION_MESSAGE);
     }
     else if (playerPick=='P'&&computerPick=='R')
     { playerWins++;
       JOptionPane.showMessageDialog(null,"Player Wins","Game: "+game,
                                    JOptionPane.INFORMATION_MESSAGE);
     }
     else 
     { computerWins++;
       JOptionPane.showMessageDialog(null,"Computer Wins","Game: "+game,
                                     JOptionPane.INFORMATION_MESSAGE);
     }
     game++;
     count++;
     choices = false;
   }
   else {JOptionPane.showMessageDialog(null,"Tie","Game: "+game,1);choices=false;}
  }
  for (count=0;count<playerWins;count++)
  {
   playerHisto += "*";
  }
  for (count=0;count<computerWins;count++)
  {
   compHisto += "*";
  }
  System.out.println("Player wins: " +playerHisto);
  System.out.println("Computer wins: " +compHisto);
 }
}