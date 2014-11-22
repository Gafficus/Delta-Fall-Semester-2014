/*Created by: Nathan Gaffney
6/NOV/2014
Week 10 Lab
*/
import java.util.Scanner;
public class Average
{
   private int[] data;
   private double mean;
   
   public Average()
   {
      data = new int[5];
      Scanner keyboard = new Scanner(System.in);
      for (int i=0; i<data.length;i++)
      {
         System.out.print("Enter score #" + (i+1)+": " );
         data[i] = keyboard.nextInt();
      }
      selectionSort(data);
      calcMean();
   }
   public void calcMean()
   {
      double total =0;
      for (int i=0; i<data.length;i++)
      {
         total += data[i];
      }
      mean = (total/5);
   }
   public String toString()
   {
      String string="";
      for (int i=0; i<data.length;i++)
      {
         string += (data[i] +"\n");
      }
      return string += mean;
   }
   public void selectionSort(int[] array)
   {
      int startScan, index, minIndex, minValue;

      for (startScan = 0; startScan < (array.length-1); startScan++)
      {
         minIndex = startScan;
         minValue = array[startScan];
         for(index = startScan + 1; index < array.length; index++)
         {
            if (array[index] < minValue)
            {
               minValue = array[index];
               minIndex = index;
            }
         }
         array[minIndex] = array[startScan];
         array[startScan] = minValue;
      }
   }
}  
