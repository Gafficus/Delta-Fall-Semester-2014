public class ParkingTicket
{
   private double amountTicket;
   //From ParkedCar
   private String carMake;
   private String carModel;
   private String carColor;
   private String carLicense;
   //From PoliceOfficer
   private String officerName;
   private String officerBadge;
   /** This method is the constructor
   @param a this will be a car object
   ParkedCar will already have necessary information
   @Param b this is a PoliceOfficer Object with information
   */
   public ParkingTicket(ParkedCar a, PoliceOfficer b)
   {
     carMake = a.getMake();
     carModel = a.getModel();
     carColor = a.getColor();
     carLicense = a.getLicenseNum(); 
     //Set Officer Data
     officerName = b.getName();
     officerBadge = b.getBadge();
   }
   public void setAmountTicket(ParkingMeter g)
   {
      if(Math.ceil(g.getMinsPurchased()/60.0)<=1)
      {
         amountTicket = 25;
      }
      else
      {
         amountTicket = 25 + 10*(Math.ceil(g.getMinsPurchased()/60)-1);
      }
   }
   public String toString()
   {
      String string;
      string = "Ticketing Officer: " + officerName+"\n" +
               "Badge Number: " + officerBadge+"\n"+
               "Car Make: " + carMake+"\n"+
               "Car Model: " + carModel+"\n"+
               "Car Color: " + carColor+"\n"+
               "License Plate: " + carLicense+"\n"+
               "Ticket Total: " + amountTicket;
      return string;
   }
}