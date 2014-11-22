/**
Program NAme: Conversion    Date:2-Oct-2014
Programmer: Nathan Gaffney  Class: CST 183
Program Description:
This program will use methods to convert user input
1. Convert to kilometers
2. Convert to miles
3. Convert to yards
4. Convert to inches
5. Convert to feet
ERRORS HANDLED: FIle not found thrown.
Dependencies: No idea
Methods:
showKilometers
showMiles
showYards
showInches
showFeet
menu 
*/
import java.util.Scanner;
import java.io.*;

public class conversion
{
  /**
  This method will convert meters into miles
  @m this is meters
  @return convert and return simultaneously
  */
  public static double showMiles(double m)
  {
  return m * 0.00062137;
  }
  /**
  THis method will convert meters to yards
  @m this is meters
  @return convert and return simultaneously
  */
  public static double showYards(double m)
  {
  return m * 1.0936;
  }
  /**
  THis method will convert meters into Inches
  @m this is meters
  @return convert and return
  */
  public static double showInches(double m)
  {
  return m * 39.37;
  }
  /**
  THis method will convert meters into feet
  @m this is meters
  @return convert and return
  */
  public static double showFeet(double m)
  {
  return m * 3.281;
  }
  /**
  This method will convert meters into kilometers.
  @m this is the number of meters
  @return convert into meters and return simultaneoulsy
  */
  public static double showKilometers(double m)
  {
   return m*0.001;
  }
  /**
  This method will display the menu for user
  */ 
  public static void menu()throws IOException
  {
    Scanner keyboard = new Scanner(System.in);
    FileWriter fw = new FileWriter("conversion_log.txt",true);
    PrintWriter outputFile = new PrintWriter(fw);
    String string="";
    for(int i=1;i<=8;i++)
    {
     switch (i)
	  {
			case 1:
            string = "This is a distance converter.";
				break;
			case 2:
            string = "Choose which unit to display.";
				break;
			case 3: 
            string = "1. Kilometers";
				break;
			case 4:
            string = "2. Miles";
				break;
			case 5:
            string = "3. Yards";
				break;
			case 6:
            string = "4. Inches";
				break;
			case 7:
            string = "5. Feet";
				break;
			case 8:
            string = "6. Close Program";
				break;
			default:
         System.out.println("Cataclysmic Failure.");
		}
      System.out.println(string);
      outputFile.println(string);
     }
     fw.flush();
     fw.close();
  }
  /**
  This method is the driver
  */
  public static void main(String args[])throws IOException
  {
   Scanner keyboard = new Scanner(System.in);
   FileWriter fw = new FileWriter("conversion_log.txt",true);
   PrintWriter outputFile = new PrintWriter(fw);
   int choice;			//the user's choice
   double distance = -1;
   double result=0;
   char letter='A';
   String string="";
	do
	{
     while (distance < 0)
     {
     System.out.print("Enter a distance in meters: ");
     distance = keyboard.nextDouble();
     }
	  menu();	
	  choice = keyboard.nextInt();
     outputFile.println(Integer.toString(choice));			
	  switch (choice)
	  {
			case 1:
            result = showKilometers(distance);
            string = " Kilometers";
				break;
			case 2:
            result = showMiles(distance);
            string = " miles";
				break;
			case 3: 
            result = showYards(distance);
            string = " yards";
				break;
			case 4:
            result = showInches(distance);
            string = " inches";
				break;
			case 5:
            result = showFeet(distance);
            string = " feet";
				break;
			case 6:
            letter = 'Y';
            outputFile.close();
            System.exit(0);
				break;
			default:
				System.out.println("You did not enter a valid choice.");
	  }
     outputFile.println(distance + " meters is " + result + string);
    }while (letter != 'Y' && letter != 'y');
    outputFile.close();
  }
}