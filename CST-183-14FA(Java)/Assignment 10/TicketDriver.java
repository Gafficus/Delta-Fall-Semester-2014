/*-------------------
Created by: NAthan Gaffney
24-November-2014
JAVA PROGRAMMING - CST-183-FA110-14FA-COURSE
This class will create a ticket.
Errors Handled: None
Dependencies: 
ParkingTicket.class
ParkedCar.class
ParkingMeter.class
PoliceOfficer.class
Method:
None
---------------------*/

import javax.swing.JOptionPane;
public class TicketDriver
{
   public static void main(String[] args)
   {
      String Make;
      String Model;
      String Color;
      String License;
      int purchased;
      
      String offName;
      String offBadge;
      int timeParked;
      
      Make = JOptionPane.showInputDialog("Enter car make:");
      Model = JOptionPane.showInputDialog("Enter car model:");
      Color  = JOptionPane.showInputDialog("Enter car color:");
      License = JOptionPane.showInputDialog("Enter car license number:");
      purchased  = Integer.parseInt(JOptionPane.showInputDialog("Enter amount of time purchased:"));
      offName = JOptionPane.showInputDialog("Enter Officer's name:");
      offBadge = JOptionPane.showInputDialog("Enter Officer's badge number:");
      timeParked = Integer.parseInt(JOptionPane.showInputDialog("How long has the car been parked:"));
      
      PoliceOfficer Officer = new PoliceOfficer(offName, offBadge);
      ParkingMeter Pole = new ParkingMeter(purchased);
      ParkedCar Car = new ParkedCar(Make, Model, Color, License, timeParked);
      if( timeParked > purchased)
      {
         ParkingTicket ticket = new ParkingTicket(Car,Officer);
         System.out.println("Ticket Issued.");
         ticket.setAmountTicket(Pole);
         System.out.print(ticket.toString());
      }
      else
      {
         System.out.println("No Ticket Issued.");
      }
      
   }
}