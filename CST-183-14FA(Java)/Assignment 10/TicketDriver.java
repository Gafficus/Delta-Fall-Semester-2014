public class TicketDriver
{
   public static void main(String[] args)
   {
      PoliceOfficer PoPo = new PoliceOfficer("John Travolta", "Face-OFF");
      ParkingMeter Poley = new ParkingMeter(530);
      ParkedCar VroomVroom = new ParkedCar("Make", "Model", "Color", "12345", 25);
      
      ParkingTicket ticket = new ParkingTicket(VroomVroom,PoPo);
      ticket.setAmountTicket(Poley);
      System.out.print(ticket.toString());
   }
}