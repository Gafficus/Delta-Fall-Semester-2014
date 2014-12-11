/*Created by: Nathan Gaffney
CST 183 Java
Assignment12
This will create an applet that wll generate a random integer.
Exceptions Handled: None
Dependencies: None
Methods:
buildfstPanel
buildSecPanel
buildBtnPanel
randInt
*/
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.applet.Applet;
import java.util.Random;

public class MyFirstApplet extends JApplet
{
   private Panel fstPanel;
   private Panel secPanel;
   private Panel btnPanel;
   private TextField txtMinimum;
   private TextField txtMaximum;
   private Label label;
   private int random;
   public void init()
   {
      buildFstPanel();
      buildSecPanel();
      buildBtnPanel();
      
      setLayout(new GridLayout(3, 1));
      
      add(fstPanel);
      add(secPanel);
      add(btnPanel);
   }
   /**
   Build the panel to hold the first number
   */
   private void buildFstPanel()
   {
      fstPanel = new Panel();
      
      Label message1 = 
               new Label("Enter the minimum integer: ");
      txtMinimum = new TextField(10);
      
      fstPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));
      fstPanel.add(message1);
      fstPanel.add(txtMinimum);
   }
   /**
   Build a panel to hold the second number
   */
   private void buildSecPanel()
   {
      secPanel = new Panel();
      
      Label message2 = 
               new Label("Enter the maximum integer: ");
      txtMaximum = new TextField(10);
      
      fstPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));
      fstPanel.add(message2);
      fstPanel.add(txtMaximum);
   }
   private void buildBtnPanel()
   {
      // Create the panel.
      btnPanel = new Panel();

      // Create a button
      Button genButton = new Button("Generate Random Integer");

      // Add an action listener to the button.
      genButton.addActionListener(new ButtonListener());

      // Add the button to the panel.
      btnPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));
      btnPanel.add(genButton);
      label = new Label("Output");
      btnPanel.add(label);
   }
   /**
   This method will implement the action listener
   */
   private class ButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
         int minimum, maximum;  
         minimum = Integer.parseInt(txtMinimum.getText());
         maximum = Integer.parseInt(txtMaximum.getText());
         random = randInt(minimum, maximum);
         label.setText(String.valueOf(random));
      }
   }
   /**
   This method will generate a random integer.
   */
   public int randInt(int min, int max) 
   {

      Random rand = new Random();
      int randomNum = rand.nextInt((max - min) + 1) + min;

      return randomNum;
   }
}