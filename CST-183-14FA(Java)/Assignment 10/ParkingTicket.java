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
}