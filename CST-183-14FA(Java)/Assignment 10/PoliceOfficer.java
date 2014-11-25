/*Created by Nathan Gaffney
24/11/2014
Create a PoliceOfficer Object
*/
public class PoliceOfficer
{
   private String name;
   private String badge;
   
   public PoliceOfficer(String a, String b)
   {
      name = a;
      badge = b;
   }
   
   public String getName()
   {
      return name;
   }
   public String getBadge()
   {
      return badge;
   }
}