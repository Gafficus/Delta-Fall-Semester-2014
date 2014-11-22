/*======================================================
Milage program
Created by: Nathan Gaffney
Date: 9-9-2014
Purpose: This program will calculate the miles per gallon of a trip.
No dependant files.
=========================================================*/
import java.util.Scanner;
public class Mileage
{
   public static void main(String [] args)
    {
        Scanner keyboard = new Scanner (System.in) ; //Scanner
        double miles; //miles driven
        double gas; //amount of gas used in gallons
        double milespergallon;
        System.out.print("This program will calculate the miles per gallon used during the trip.\n"); //Display purpose
        System.out.print("Enter the number of miles driven."); //prompt for miles driven
        miles = keyboard.nextDouble(); // get miles driven
        System.out.print("Enter the number of gallons of gas used."); //prompt for gas used
        gas = keyboard.nextDouble(); // get gas used
        milespergallon = miles / gas; // divide miles driven by gas used
        System.out.println("Miles per gallon: " +milespergallon); //output the miles per gallon
    }
}