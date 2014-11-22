/*--------------------------
Created by: Nathan Gaffney
9 - Oct - 2014
Model of a television
---------------------------*/
public class Television
{
   private String MANUFACTURER; //The manufacturer
   private int SCREEN_SIZE; //Size of teelevision screen
   private boolean powerOn;//On or Off
   private int channel;//Channel
   private int volume;//Volume level
   
   /**
   THis method is the constructor.
   @MAN is the MANUFACTURER
   @SS is the screen size
   THis will:
   set powerOn to off
   set the volume to 20
   set the channel to 2
   */
   public Television(String MAN, int SS)
   {
      MANUFACTURER = MAN;
      SCREEN_SIZE = SS;
      powerOn = false;
      volume = 20;
      channel = 2;
   }
   /**
   This method will set the channel field.
   @station this is what the channel will become
   */
   public void setChannel(int station)
   {
      channel = station;
   }
   /**
   This will toggle the power variable
   If true will become false
   If false will become true
   */
   public void power()
   {
      powerOn = !powerOn;
   }
   /**
   This method will increment the volume by 1
   */
   public int increaseVolume()
   {
      return volume++;
   }
   /**
   This method will decrease the volume by 1
   */
   public int decreaseVolume()
   {
      return volume--;
   }
   /**
   This method will return the value stored in channel
   */
   public int getChannel()
   {
      return channel;
   }
   /**
   This method will return the value stored in channel
   */
   public int getVolume()
   {
      return volume;
   }
   /**
   This method will return the string stored in MANUFACTURER
   */
   public String getManufacturer()
   {
      return MANUFACTURER;
   }
   /**
   This method will return the value stored in SCREEN_SIZE
   */
   public int getScreenSize()
   {
      return SCREEN_SIZE;
   }
}