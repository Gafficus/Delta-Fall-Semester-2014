/*Created by Nathan Gaffney
24/NOV/2014
Create a simulation of a parking meter
Store the time purchased
Methods:
getMinsPurchased
setMinsPurchased
*/
public class ParkingMeter
{
   private int minsPurchased;
   
   public ParkingMeter(int a)
   {
      minsPurchased = a;
   }
   /**This method will get the amount of time purchased
   @return return the minsPurchased
   */
   public int getMinsPurchased()
   {
      return minsPurchased;
   }
   /** This method will set the number of minutes purchased
   @param t the amount of time to be bought
   */
   public void setMinsPurchased(int t)
   {
      minsPurchased = t;
   }
}