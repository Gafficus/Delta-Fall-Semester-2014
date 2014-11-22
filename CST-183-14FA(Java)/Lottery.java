/*-------------------
Created by: NAthan Gaffney
17-November-2014
JAVA PROGRAMMING - CST-183-FA110-14FA-COURSE
This class will create a lottery simulation program.
Errors Handled: None
Dependencies: None
Method:
Lottery
getNums
winnings
---------------------*/
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.Random;
import java.util.Scanner;

public class Lottery
{
   private int[] lotteryNumbers;
   private int[] playerNumbers;
   private String lotNums ="";
   private String plyNums = "";
   /** This is the constructor
   It will create an object and then call the methods*/
   public Lottery()
   {
      Random random = new Random();
      lotteryNumbers = new int[6];
      playerNumbers = new int[6];
      for (int i=0; i < lotteryNumbers.length;i++)
      {
         lotteryNumbers[i] = randInt(random,0,47);
      }
      getNums();
      for (int i=0; i < lotteryNumbers.length;i++)
      {
        lotNums += lotteryNumbers[i] + " ";
      }
      for (int i=0; i<playerNumbers.length;i++)
      {
         plyNums += playerNumbers[i] + " ";
      }
      System.out.println("Lottery numbers: " +lotNums);
      System.out.println("Player numbers: " +plyNums);
      System.out.println(winnings(playerNumbers));
      
   }
   /**Found on stackOVerFlow by Greg Case
   This mthod will create a random number based on the parameters sent
   @param min the miimum value of the range
   @param max the maximum value of the range
   */
   public static int randInt(Random rand,int min, int max)
   {
      int randomNum = rand.nextInt((max-min)+1)+min;
      return randomNum;
   }
   /**This method will prompt the user for their lottery numbers
   Storing them in an array.*/
   public void getNums()
   {
      String string="";
      Scanner keyboard = new Scanner(System.in);
      for (int i=0; i<playerNumbers.length;i++)
      {
         switch (i)
	      {
            case 0:
             string = "first ";
             break;
			   case 1:
               string = "second ";
				   break;
			   case 2:
               string = "third ";
				   break;
			   case 3: 
               string = "fourth ";
				   break;
			   case 4:
               string = "fifth ";
				   break;
			   case 5:
               string = "sixth ";
				   break;
			   default:
               System.out.println("Cataclysmic Failure.");
          }
         System.out.println("Enter your "+string+"number.");
         playerNumbers[i] = keyboard.nextInt();
      }
   }
   /**This method will determine how many numbers are the same
   Based on similar numbers will determine a prize*/
   public String winnings(int[] picks)
   {
      String string ="";
      int numSame = 0;
      for (int i=0; i <lotteryNumbers.length; i++)
      {
         for (int j=0; j<picks.length;j++)
         {
            if (picks[j] == lotteryNumbers[i])
            {
               numSame ++;
            }
         }
      }
      switch (numSame)
	      {
            case 0:
               string = "You won  a free ticket for the next drawing!";
               break;
			   case 1:
               string = "You won  $5.00!";
				   break;
			   case 2:
               string = "You won  $25.00";
				   break;
			   case 3: 
               string = "You won $500.00";
				   break;
			   case 4:
               string = "You won  $5000.00!";
				   break;
			   case 5:
               string = "You won  $100,000.00!";
				   break;
            case 6:
               string = "You won $1,000,000.00!";
               break;
			   default:
               System.out.println("Cataclysmic Failure.");
          }
     return string ;
   }
   /**Main*/
   public static void main(String[] args)
   {
      Lottery lot = new Lottery();
   }
   
}