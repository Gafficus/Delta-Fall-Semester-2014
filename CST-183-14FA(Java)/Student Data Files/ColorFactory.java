/*-------------------
Create By : Nathan Gaffney
21-OCT-2014
LAB for Chapter 12
--------------------*/
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
public class ColorFactory extends JFrame
{
   final int WINDOW_WIDTH = 500;
   final int WINDOW_HEIGHT = 300;
   private JLabel message;
   //Content Pane
   private Container contentPane;
   //Panels
   private JPanel topPanel;
   private JPanel bottomPanel;
   //Color Buttons
   private JButton redButton;
   private JButton yellowButton;
   private JButton orangeButton;
   private JRadioButton greenButton;
   private JRadioButton blueButton;
   private JRadioButton cyanButton;
   private ButtonGroup radioButtonGroup;
   
   
   public ColorFactory()
   {
      //Create a window with set size
      setTitle("Color Factory");
      setSize(WINDOW_WIDTH,WINDOW_HEIGHT);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
      //Content Pane
      contentPane = new JPanel();
      contentPane.setLayout(new BorderLayout());
      setLayout(new BorderLayout());
      add(contentPane,BorderLayout.CENTER);
      //Top Panel
      buildTopPanel();
      add(topPanel, BorderLayout.NORTH);
      //Bottom Panel
      buildBottomPanel();
      add(bottomPanel, BorderLayout.SOUTH);
      //create a message and add to the window
      message = new JLabel("Top buttons change the "
                         + "panel color and bottom radio "
                         + "buttons change the text color.");
      contentPane.add(message,BorderLayout.CENTER);
   }
   private void buildTopPanel()
   {
      topPanel = new JPanel();//top panel
      topPanel.setBackground(Color.white);
      topPanel.setLayout(new FlowLayout());
      
      //create three buttons : red, orange, yellow, setting background, actions
      //comands, and adding listener
      redButton = new JButton("Red");
      redButton.addActionListener(new ButtonListener());
      redButton.setBackground(Color.red);
      orangeButton = new JButton("Orange");
      orangeButton.addActionListener(new ButtonListener());
      orangeButton.setBackground(Color.orange);
      yellowButton = new JButton("Yellow");
      yellowButton.addActionListener(new ButtonListener());
      yellowButton.setBackground(Color.yellow);
      //add buttons to panel
      topPanel.add(redButton);
      topPanel.add(orangeButton);
      topPanel.add(yellowButton);

   }
   private void buildBottomPanel()
   {
      bottomPanel = new JPanel();
      bottomPanel.setBackground(Color.white);
      bottomPanel.setLayout(new FlowLayout());
      
      //create three radio buttons : green, blue, cyan, setting background, actions
      //comands, and adding listener
      greenButton = new JRadioButton("Green");
      greenButton.addActionListener(new RadioButtonListener());
      greenButton.setForeground(Color.green);
      blueButton = new JRadioButton("Blue");
      blueButton.addActionListener(new RadioButtonListener());
      blueButton.setForeground(Color.blue);
      cyanButton = new JRadioButton("Cyan");
      cyanButton.addActionListener(new RadioButtonListener());
      cyanButton.setForeground(Color.cyan);
      //add buttons to group
      radioButtonGroup = new ButtonGroup();
      radioButtonGroup.add(greenButton);
      radioButtonGroup.add(blueButton);
      radioButtonGroup.add(cyanButton);
      
      //add buttons to panel
      bottomPanel.add(greenButton);
      bottomPanel.add(blueButton);
      bottomPanel.add(cyanButton);
   }
   /** Button listener changes the color of background
   depending on which button is clicked*/
   private class ButtonListener implements ActionListener
   {
      public void actionPerformed (ActionEvent event)
      {
         String whichButton = event.getActionCommand();
         if(whichButton.equals("Red"))
         {
            contentPane.setBackground(Color.red);
         }
         else if (whichButton.equals("Orange"))
         {
            contentPane.setBackground(Color.orange);
         }
         else if (whichButton.equals ("Yellow"))
         {
            contentPane.setBackground(Color.yellow);
         }
      }
   }
   /**Changes color of the foreground(text)
   depending on which radio button is clickedc*/
   private class RadioButtonListener implements ActionListener
   {
      public void actionPerformed (ActionEvent event)
      {
         if (event.getSource() == greenButton)
         {
            message.setForeground(Color.green);
         }
         else if ( event.getSource() == blueButton)
         {
            message.setForeground(Color.blue);
         }
         else if (event.getSource() == cyanButton)
         {
            message.setForeground(Color.cyan);
         }
      }
   }
   public static void main(String[] args)
   {
      ColorFactory labGUI = new ColorFactory();
      labGUI.setVisible(true);
   }
}