/*---------------------
Created by: NAthan Gaffney
29-October-2014
JAVA PROGRAMMING - CST-183-FA110-14FA-COURSE
This class will create an order for skateboard parts.
Errors Handled: 
Dependencies: None
Methods:
buildContentPane
buildPanButtons
clearTexts
calcTotals
----------------------*/
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class SkateBoard extends JFrame
{
   //Window Size
   final int WINDOW_WIDTH = 720;
   final int WINDOW_HEIGHT = 600;
   //Container
   private Container contentPane;
   private Container titlePane;
   private Container westPane;
   private Container eastPane;
   private Container southPane;
   //Lists
   private JList lstDecks;
   private JList lstTruckAssemblies;
   private JList lstWheels;
   private JList lstMisc;
   //Buttons
   private JButton btnExit;
   private JButton btnCalcOrder;
   //Labels
   private JLabel lblShopName;
   private JLabel lblTotal;
   //Text Filed
   private JTextField txtTotal;
   //private JLabel lbl
   
   public SkateBoard()
   {
      createForgottenPane();
      
      //Basic WIndow Creation
      setTitle("Computron...");
      setSize(WINDOW_WIDTH,WINDOW_HEIGHT);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      

      
      //Create the title panel
      //Doesn't change anythign currently
      //Easier if left out
      
      //Create the content pane
      buildContentPane();
      add(contentPane,BorderLayout.CENTER);
      
      buildTitlePane();
      add(titlePane,BorderLayout.NORTH);
      /*Put the Dec and TruckAssemblies on West */
      //Put the Wheel and Misc on the East
      //Put the two buttons on the SOUTH
      //SplitPane Left and Right
      //Nested SplitPane Top and Bottom
      //Maybe make the Lists scrollable as needed?
      
   }
   private void createForgottenPane()
   {
      
      JPanel eastPane = new JPanel();
      JPanel southPane = new JPanel();
      JPanel westPane = new JPanel();
      westPane.setLayout(new BorderLayout());
      //------------------Left----------------------
      //THis will make the left side of window
      String[] decks = {"The Master Thrasher: $40", "The Dictator: $45",
                        "The Street King: $50", "The Judge: $60"};
      JList lstDecks = new JList(decks);
      lstDecks.setSelectionMode(
                ListSelectionModel.SINGLE_SELECTION);
      //lstDecks.addListSelectionListener(
      //                           new ListListener());
      lstDecks.setVisibleRowCount(4);
      westPane.add(lstDecks,BorderLayout.NORTH);
      
      String[] truckAss = {"7.75 inch axle: #35", "8 inch axle: $40",
                           "8.5 inch axle: $45"};
      JList lstTruckAssemblies = new JList(truckAss);
      lstTruckAssemblies.setSelectionMode(
                ListSelectionModel.SINGLE_SELECTION);
      //lsTruckAssemblies.addListSelectionListener(
      //                           new ListListener());
      lstTruckAssemblies.setVisibleRowCount(3);
      westPane.add(lstTruckAssemblies,BorderLayout.SOUTH);
      //---------------End Left----------------------
      
      //------------------Right----------------------
      //THis will make the right side of the window
      //Wheels and Misc
      String[] wheels = {"51 mm: $20","55 mm: $22","58 mm: $24","61 mm: $28"};
      String[] misc = {"Grip Tape: $10","Bearings: $30","Riser Pads: $2",
                       "Nuts & Bolts kit: $3","Board shorts: $38","T-Shirts: $21",
                       "Band-Aids: $5"};
      JList lstWheels = new JList(wheels);
      JList lstMisc = new JList(misc);
      lstWheels.setSelectionMode(
              ListSelectionModel.SINGLE_SELECTION);
      lstMisc.setSelectionMode(
              ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
      lstWheels.setVisibleRowCount(4);
      lstMisc.setVisibleRowCount(7);
      eastPane.add(lstWheels,BorderLayout.EAST);
      eastPane.add(lstMisc,BorderLayout.WEST); 
      //----------------End Right--------------------
      add(westPane,BorderLayout.WEST);
      add(eastPane,BorderLayout.EAST);
      add(southPane,BorderLayout.SOUTH);
   }
   private void buildContentPane()
   {
      contentPane = new JPanel();
   }
   private void buildTitlePane()
   {
      titlePane = new JPanel();
      //Company Name
      lblShopName = new JLabel("Rocket Power Conglomerate Shop INC.");
      titlePane.add(lblShopName);
      
   }

   public void createTruckAssemblies()
   {
      
      
   }
   public void createWheels()
   {
      
   }
   public void createMisc()
   {
      
   }
   /*
   private class ListListener
                    implements ListSelectionListener
   {
      public void valueChanged(ListSelectionEvent e)
      {
         String selection =
                  (String) lst
      }
   }*/

   public static void main(String[] args)
  	{
   	SkateBoard gui = new SkateBoard();
      gui.setVisible(true);
   }

}