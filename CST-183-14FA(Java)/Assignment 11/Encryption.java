/*~~~~~~~~~~~~~~~~~~~~~~
Dependencies:
CharUtils.java
~~~~~~~~~~~~~~~~~~~~~~~~*/
public class Encryption
{
   public static String encrypt(String data)
   {
      /*
      Grab string to be encoded
      Walk through string as array
         Modify the ascii codes +13
         if code> 13 dont add but subtract
      */
      StringBuilder encrypted = new StringBuilder(data);
      for(int i=0;i < data.length();i++)
      {
         int intValue = CharUtils.CharToASCII(data.charAt(i));
         char newChar;
         if (intValue <=109)
         {
            intValue += 13;
         }
         else 
         {
            if (intValue<=122)
            {
               intValue -= 13;
            }
            else
            {
               System.out.println("Failure State.");
            }
         }
         
         encrypted.setCharAt(i,CharUtils.ASCIIToChar(intValue));
      }
      return encrypted.toString();
       
   }
   public static String decrypt(String data)
   {
      /*
      Grab string to be decoded
      Walk through string as array
         Modify the ascii codes -13
         if code<13 dont subtract but add
      
      */
      StringBuilder decrypted = new StringBuilder(data);
      for(int i=0;i <data.length();i++)
      {
         int intValue = CharUtils.CharToASCII(data.charAt(i));
         char newChar;
         if (intValue <=109)
         {
            intValue += 13;
         }
         else 
         {
            if (intValue<=122)
            {
               intValue -= 13;
            }
            else
            {
               System.out.println("Extreme Failure.");
            }
         }
         
         decrypted.setCharAt(i,CharUtils.ASCIIToChar(intValue));
      }
      return decrypted.toString();
   }
}