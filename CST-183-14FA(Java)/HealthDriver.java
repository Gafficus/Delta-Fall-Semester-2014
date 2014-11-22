/*-------
Prgram Name: HealthDriver  Date:09/Oct/2014
PRogrammer: Nathan Gaffney Class:CST183-Java
Program Description:
THis program acts as the driver for the healthlog
It will prompt the user for basic data
Then it will preform calculations based on that data
Errors Handled: None
Dependencies: HealthLog.class
Methods: Main
-------*/
import java.util.Scanner;
public class HealthDriver
{
   public static void main(String args[])
   {
      Scanner keyboard = new Scanner (System.in);
      int age;
      double height;
      double weight;
      double speed;
      double workingOut;
      char gender;
      boolean runner;
      char run;
      
      System.out.print("Enter your age: ");
      age = keyboard.nextInt();
      System.out.print("Enter your height(in inches): ");
      height = keyboard.nextDouble();
      System.out.print("Enter your weight(in pounds): ");
      weight = keyboard.nextDouble();
      System.out.print("Enter your gender M/F: ");
      gender = keyboard.next().charAt(0);
      System.out.print("Do you run? Y/N :");
      run = keyboard.next().charAt(0);
      if (run == 'Y' || run == 'y'){runner = true;}
      else{runner = false;}
      System.out.println();
      System.out.print("How fast do you walk/run in mph? :");
      speed = keyboard.nextDouble();
      System.out.print("How long do you run/walk in minutes: ");
      workingOut = keyboard.nextDouble();
      
      HealthLog hl = new HealthLog(age,height,weight,gender,runner,speed,workingOut);
      System.out.println("Calories burned during workout: " + hl.caloriesSpent());
      System.out.println("Maximum Target Heart Range: " + hl.maxTHR());
      System.out.println("Minimum Target Heart Range: " + hl.minTHR());
      System.out.println("Body Mass Index: "+hl.getBMI());
      System.out.println("Body Mass Classification: " + hl.bmiClass());
      System.out.println("Minimum daily energy requirements: " + hl.minEnergy());
    
   }
}