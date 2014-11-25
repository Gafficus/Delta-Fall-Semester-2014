/*
Created by Nathan Gaffney
24/NOV/2014
Create a model of a parked car
*/
public class ParkedCar
{
  private String make;
  private String model;
  private String color;
  private String licenseNum;
  private int minsParked; 
  
  public String getMake()
  {
   return make;
  }
  /**
  This method will set the make.
  @param make this is what the make will become
  */
  public void setMake(String s)
  {
   make = s;
  }
  public String getModel()
  {
   return make;
  }
  /**
  This method will set the model field.
  @param model this is what the model will become
  */
  public void setModel(String s)
  {
   model = s;
  }
  public String getColor()
  {
   return color;
  }
  /**
  This method will set the color field.
  @param color this is what the color will become
  */
  public void setColor(String s)
  {
   color = s;
  }
  public String getLicenseNum()
  {
   return licenseNum;
  }
  /**
  This method will set the channel field.
  @param licenseNum this is what the licenseNum will become
  */
  public void setLicenseNum(String s)
  {
   licenseNum = s;
  }
  public int getMinsParked()
  {
   return minsParked;
  }
  /**
  This method will set the minParked field.
  @param minsParked how long the car has been parked
  */
  public void setMinsParked(int n)
  {
   minsParked = n;
  }
}