public class Encryption
{
   private String data;
   
   public Encryption(String importantInfo)
   {
      Character.toLowerCase(importantInfo);
      Case(importantInfo);
      data = importantInfo;
      
   }
   public encrypt()
   {
      /*
      Grab string to be encoded
      Walk through string as array
         Modify the ascii codes +13
         if code> 13 dont add but subtract
      */
      for(int i=0;data.length;i++)
      {
         if(data[i]
      {
   }
   public decrypt()
   {
      /*
      Grab string to be decoded
      Walk through string as array
         Modify the ascii codes -13
         if code<13 dont subtract but add
      
      */
   }
}