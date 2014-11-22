/*===============================================
EndingTime created by Nathan Gaffney
THis program will take a time entered by user,
add the duration of an event and then,
will convert that time from military to standard.
10-Sep-2014
THere are no other program dependencies.
===============================================*/
import java.util.Scanner;
public class EndingTime
{
  public static void main(String [] args)
  {
  // Variable declarations
  int hoursInMins;
  int minutes;
  int startingTime;
  int endingTime;
  int endingMins;
  int endingHours;
  int duration;
  // Hint: All variables need to be declared as integers
  // Create a Scanner object to read from the keyboard
  Scanner keyboard = new Scanner(System.in);
  
  // Get the starting time in hours and minutes
  System.out.print("What is the starting time?: ");
  hoursInMins = keyboard.nextInt();
  minutes = keyboard.nextInt();
  // Get the duration time in minutes
  System.out.print("How long does it last (in minutes)?: ");
  duration = keyboard.nextInt();
  // Calculate the ending time 
  startingTime = hoursInMins*60 + minutes;
  endingTime = startingTime + duration;
  endingHours = endingTime / 60; //Breaks time into hours
  endingMins = endingTime % 60; //Gets minutes
  endingHours = ((endingHours+11)%12)+1;
  System.out.println("Ending hours is " +endingHours);
  System.out.println("Ending minute is " + endingMins);
  // Display the output
  }
}