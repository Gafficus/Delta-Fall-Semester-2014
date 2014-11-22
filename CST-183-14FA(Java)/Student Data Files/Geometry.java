/*---------------------
Edited by: NAthan Gaffney
7 - OCt-2014
----------------------*/
import java.util.Scanner;

/**
	This program demonstrates static methods
*/

public class Geometry
{
   /**
   This function will print out a menu to the user.
   This is a geometry calculator
   Choose what you would like to calculate
   1. Find the area of a circle
   2. Find the area of a rectangle
   3. Find the area of a triangle
   4. Find the circumference of a circle
   5. Find the perimeter of a rectangle
   6. Find the perimeter of a triangle
   Enter the number of your choice: 
   */
   public static void printMenu()
   {
      System.out.println("This is a geometry calculator.");
      System.out.println("Choose what you would like to calculate:");
      System.out.println("1. Find the area of a circle.");
      System.out.println("2. Find tyhe area of a rectangle.");
      System.out.println("3. Find the area of a triangle.");
      System.out.println("4. Find the cicumfrence of a circle");
      System.out.println("5. Find the perimeter of a rectangle");
      System.out.println("6. Find the perimeter of a triangle.");
      System.out.print("Enter the number of your choice: ");
   }
   /**
   This method will recieve an integer
   Then do the formula for area
   A=(3.14159265359) * r^2
   @r is the radius of the circle
   @return is the area of a cricle
   */
   public static double circleArea(double r)
   {
      return Math.PI * Math.pow(r, 2);
   }
   /**
   This method will find the area oif a rectangle
   A = length * width
   @l is the length
   @w is the width
   @return is the area of a rectangle
   */
   public static double rectangleArea(double l, double w)
   {
      return l * w;
   }
   /**
   This method will find the area of a triangle
   A = .5 * base * height
   @b is the base
   @w is the width
   @return is the area of a triangle
   */
   public static double triangleArea(double b, double h)
   {
      return (.5)* b * h;
   }
   /**
   This method will find the circumference of a cricle
   C = 2*(3.14159265359)*r
   @r is the radius
   @return is the Circumference of a circle
   */
   public static double circleCircumference(double r)
   {
      return 2 * Math.PI * r;
   }
   /**
   This method will find the perimeter of a rectangle
   A = 2l + 2w
   OR
   A = 2(l+w)
   @l is the length
   @w is the width
   @return is the perimeter of a rectangle
   */
   public static double rectanglePerimeter(double l, double w)
   {
      return 2*(l+w);
   }
   /**
   This method will find the perimeter of a trianlge
   P= a+b+c
   @a is the first side
   @b is the second side
   @c is the third side
   @return is ther perimeter of a triangle
   */
   public static double trianglePerimeter(double a, double b, double c)
   {
      return a+b+c;
   }
	public static void main (String [] args)
	{
		int choice;			//the user's choice
		double value = 0;	//the value returned from the method
		char letter;		//the Y or N from the user's decision to exit
		double radius;		//the radius of the circle
		double length;		//the length of the rectangle
		double width;		//the width of the rectangle
		double height;		//the height of the triangle
		double base;		//the base of the triangle
		double side1;		//the first side of the triangle
		double side2;		//the second side of the triangle
		double side3;		//the third side of the triangle
		
		//create a scanner object to read from the keyboard
		Scanner keyboard = new Scanner (System.in);
		
		//do loop was chose to allow the menu to be displayed first
		do
		{
			printMenu();
			
			choice = keyboard.nextInt();
						
			switch (choice)
			{
				case 1:
					System.out.print("Enter the radius of the circle:  ");
					radius = keyboard.nextDouble();
					//call the circleArea method and store the result in the value variable
               value = circleArea(radius);			
					
					System.out.println("The area of the circle is " + value);
					break;
				case 2:
					System.out.print("Enter the length of the rectangle:  ");
					length = keyboard.nextDouble();
					System.out.print("Enter the width of the rectangle:  ");
					width = keyboard.nextDouble();
					//call the rectangleArea method and store the result in the value variable
               value = rectangleArea(length, width);
			
					System.out.println("The area of the rectangle is " + value);
					break;
				case 3: 
					System.out.print("Enter the height of the triangle:  ");
					height = keyboard.nextDouble();
					System.out.print("Enter the base of the triangle:  ");
					base = keyboard.nextDouble();
					//call the triangleArea method and store the result in the value variable
               value = triangleArea(base, height);
				
					System.out.println("The area of the triangle is " + value);
					break;
				case 4:
					System.out.print("Enter the radius of the circle:  ");
					radius = keyboard.nextDouble();
					//call the circumference method and store the result in the value variable
               value = circleCircumference(radius);
			
					System.out.println("The circumference of the circle is " + value);
					break;
				case 5:
					System.out.print("Enter the length of the rectangle:  ");
					length = keyboard.nextDouble();
					System.out.print("Enter the width of the rectangle:  ");
					width = keyboard.nextDouble();
					//call the perimeter method and store the result in the value variable
               value = rectanglePerimeter(length,width);
					
					System.out.println("The perimeter of the rectangle is " + value);
					break;
				case 6:
					System.out.print("Enter the length of side 1 of the triangle:  ");
					side1 = keyboard.nextDouble();
					System.out.print("Enter the length of side 2 of the triangle:  ");
					side2 = keyboard.nextDouble();
					System.out.print("Enter the length of side 3 of the triangle:  ");
					side3 = keyboard.nextDouble();
					//call the perimeter method and store the result in the value variable
               value = trianglePerimeter(side1,side2,side3);
					
					System.out.println("The perimeter of the triangle is " + value);
					break;
				default:
					System.out.println("You did not enter a valid choice.");
			}	
			keyboard.nextLine(); //consumes the new line character after the number						
			System.out.println("Do you want to exit the program (Y/N)?:  ");
			String answer = keyboard.nextLine();
			letter = answer.charAt(0);
		}while (letter != 'Y' && letter != 'y');
	}
}