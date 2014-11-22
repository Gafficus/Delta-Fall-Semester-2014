import java.text.DecimalFormat; //for number formatting
import java.util.Scanner;		 //for keyboard input
import java.io.*;             //for using files

public class StatsDemo
{
	public static void main(String [] args)throws IOException//ADD A THROWS CLAUSE HERE
	{
		double sum = 0;		   //the sum of the numbers
		int count = 0;		     //the number of numbers added
		double mean = 0;  	 //the average of the numbers
		double stdDev = 0;	//the standard deviation of the numbers
		String line;		  //a line from the file
		double difference; //difference between the value and the mean

		//create an object of type Decimal Format
		DecimalFormat threeDecimals = new DecimalFormat("0.000");
		//create an object of type Scanner
		Scanner keyboard = new Scanner (System.in);
		String filename;	// the user input file name

		//Prompt the user and read in the file name
		System.out.println("This program calculates statistics"
			+ "on a file containing a series of numbers");
		System.out.print("Enter the file name:  ");
		filename = keyboard.nextLine();

		//ADD LINES FOR TASK #4 HERE
		//Create a FileReader object passing it the filename
      File file = new File(filename);
      //Create a BufferedReader object passing it the FileReader object.
		BufferedReader reader = new BufferedReader(new FileReader(filename));
      Scanner inputFile = new Scanner(file);
		//priming read to read the first line of the file
      //line = inputFile.nextLine();			
      while (inputFile.hasNext()) //Read file loop
      {
        line = inputFile.nextLine(); //read a new line from the file
        sum += Double.parseDouble(line); //convert the line into a double value and add the value to the sum
        count++;          //increment the counter

      }
		inputFile.close(); //close the input file
		mean = sum / count; //store the calculated mean

		//ADD LINES FOR TASK #5 HERE
		//reconnect to the FileReader object passing it the filename
       File File = new File(filename);
		//reconnect to the BufferedReader object passing it the FileReader object.
      Scanner InputFile = new Scanner(File);
		//reinitialize the sum of the numbers
      sum = 0;
		//reinitialize the number of numbers added
      count = 0;
		//priming read to read the first line of the file
      while (InputFile.hasNext()) //Read file loop
      {
        line = InputFile.nextLine(); //read a new line from the file
        difference = Double.parseDouble(line)- mean; //convert the line into a double value and add the value to the sum
        sum += difference * difference;
        count++;          //increment the counter

      }
		InputFile.close(); //close the input file
      stdDev = Math.sqrt(sum/count);


		//ADD LINES FOR TASK #3 HERE
		//create an object of type FileWriter using “Results.txt”
      FileWriter fw = new FileWriter("Results.txt");
		//create an object of PrintWriter passing it the FileWriter object.
      PrintWriter outputFile = new PrintWriter(fw);
		//print the results to the output file
      outputFile.println("The mean is: " + threeDecimals.format(mean));
      outputFile.println("The standard deviation is: " + threeDecimals.format(stdDev));
      outputFile.close();//close the output file
	}
}