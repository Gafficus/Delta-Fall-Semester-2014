/**
   This program demonstrates how numeric types and operators behave in Java
*/

//TASK #2  Add import statement here to use the Scanner class
import java.util.Scanner;
import javax.swing.JOptionPane;
//TASK #2  (Alternate) Add import statment to use JOptionPane class

public class NumericTypes
{
	public static void main (String [] args)
	{
		//TASK #2 Create a Scanner object here (not used for alternate)
	   Scanner keyboard = new Scanner (System.in) ; //Scanner
		//identifier declarations
		final int NUMBER = 2 ;		       // number of scores
		final double SCORE1 = 100;		   // first test score
		final double SCORE2 = 95;		  // second test score
		final int BOILING_IN_F = 212;  // freezing temperature
		double fToC;						   // temperature in celsius
		double average;				  // arithmetic average
		String output;					 // line of output to print out
		//TASK #2 declare variables used here
      String firstName;
      String lastName;
      String fullName;
		//TASK #3 declare variables used here
      char firstInitial;
      
		//TASK #4 declare variables used here
      double diameter;
      double radius;
      double volume;

		// Find an arithmetic average
		average = (SCORE1 + SCORE2) / NUMBER;
		output = SCORE1 + " and " + SCORE2 + " have an average of "
				+ average;
		System.out.println(output);

		// Convert Fahrenheit temperatures to Celsius
		fToC = 5 * (BOILING_IN_F - 32) / 9;
		output = BOILING_IN_F + " in Fahrenheit is " + fToC
			     + " in Celsius.";
		System.out.println(output);
		System.out.println();		// to leave a blank line
		
      // ADD LINES FOR TASK #2 HERE
		System.out.print("Enter your first name: "); // prompt the user for first name
		firstName = keyboard.nextLine();// read the user's first name
		System.out.print("Enter your last name: ");// prompt the user for last name
		lastName = keyboard.nextLine();// read the user's last name
		fullName = firstName + " " + lastName;// concatenate the user's first and last names
		System.out.print(fullName);// print out the user's full name 

		// ADD LINES FOR TASK #2 Alternate HERE
		// prompt the user for first name
		firstName = JOptionPane.showInputDialog("Enter your first name."); // read the user's first name
		lastName = JOptionPane.showInputDialog("Enter your last name."); // read the user's last name
		fullName = firstName + " " + lastName;// concatenate the user's first and last names
		JOptionPane.showMessageDialog(null, fullName);// print out the user's full name 

		System.out.println();		// to leave a blank line
		
		// ADD LINES FOR TASK #3 HERE
		firstInitial = firstName.charAt(0);// get the first character from the user's first name
		System.out.print(firstInitial);// print out the user's first initial
  		System.out.println();		// to leave a blank line
		fullName = fullName.toUpperCase();// convert the user's full name to all capital letters
		System.out.print(fullName);// print out the user's full name in all capital letters

		System.out.println();		// to leave a blank line
		
		// ADD LINES FOR TASK #4 HERE
		System.out.print("Enter the diameter of a shpere: ");// prompt the user for a diameter of a sphere
		diameter =keyboard.nextDouble(); // read the diameter
		radius = diameter / 2;// calculate the radius
		volume = (4 * Math.PI * Math.pow(radius, 3.0))/3;// calculate the volume 
		System.out.print("The volume of the sphere is: " +volume);// print out the volume
	}	
}