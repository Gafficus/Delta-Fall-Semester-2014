/**********************************************
   This program analyzes the user's BMI
   Created by: Nathan Gaffney
   17- Sep - 2014
   JAVA PROGRAMMING - CST-183-FA110-14FA-COURSE
   Program 3
***********************************************/
import java.util.Scanner;
import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class JavaProgram3
{
  public static void main (String[] args)
  {
    Scanner keyboard = new Scanner (System.in);
    DecimalFormat decFormat = new DecimalFormat("#0.0");
    //Variable Declarations
    double height;
    double weight;
    double BMI;
    int MHR;
    int age;
    int lowEnd;
    int highEnd;
    boolean athlete;
    String weightRange;
    String input;
    String bmiOutput;
    String heartOutput;
    char athleteChar;
    
    System.out.print("Please enter your height (in inches): ");
    height = keyboard.nextDouble();//Get the user's height
    System.out.print("\nPlease enter your weight(in pounds): ");
    weight = keyboard.nextDouble();//Get the user's weight
    System.out.print("\nPlease enter your age: ");
    age = keyboard.nextInt();//Get the user's age
    System.out.print("Are you an athlete?(Y/N):");
    input = keyboard.next();//Get the user's input
    athleteChar = input.charAt(0);
    if (athleteChar== 'Y' ||athleteChar== 'y') 
       {
       athlete = true;
       }
    else if (athleteChar == 'N' || athleteChar== 'n') 
       {
       athlete = false;
       }
    else
    {  
    System.out.println("Invalid entry defaulting to no."); 
    athlete= false;
    }
    
    BMI = (703 * weight) / (height*height);
    if (BMI < 18.5) {weightRange = "underweight";}
    else if (BMI <25.0) {weightRange = "Normal";}
    else if (BMI <30) {weightRange = "OVerweight";}
    else {weightRange = "Obese";}
    
    MHR = (int)Math.round(217 - (.85 * age));
    if (athlete && age<50) {MHR -=3;}//Subtract 3 for healthy
    else if (athlete && age<55) {MHR+=2;}//Add 2 for age
    else if (athlete && age>=55) {MHR+=4;}//Add 4 for extreme age
    else {MHR = MHR;}//Non-Athlete
    
    //optimal ragnges
    lowEnd = (int)Math.round(.60 * MHR);
    highEnd = (int)Math.round(.80 * MHR);
    
    //Begin output
    bmiOutput = "Body MAss Index: " + decFormat.format(BMI)+ " (" + weightRange + ")";
    heartOutput ="\nYour training heart rate should be between "+ lowEnd + " and "+ highEnd;
    JOptionPane.showMessageDialog(null,bmiOutput);
    JOptionPane.showMessageDialog(null,heartOutput);
    }
}