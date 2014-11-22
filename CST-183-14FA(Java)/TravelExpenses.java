/*---------------------
Created by: NAthan Gaffney
22-October-2014
JAVA PROGRAMMING - CST-183-FA110-14FA-COURSE
This class will create a reimbursement report.
Errors Handled: 
Dependencies: None
Methods:
buildContentPane
buildPanButtons
clearTexts
calcTotals
----------------------*/
import java.text.DecimalFormat;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.JOptionPane;
public class TravelExpenses extends JFrame
{
   final int WINDOW_WIDTH = 325;
   final int WINDOW_HEIGHT = 300;
   //--------------------
   //Expenses WIndow
   //Containers
   private Container contentPane;
   //Panels 
   private JPanel panButtons;
   //Labels
   private JLabel lblDays;
   private JLabel lblAirfare;
   private JLabel lblRental;
   private JLabel lblMiles;
   private JLabel lblParking;
   private JLabel lblTaxi;
   private JLabel lblConference;
   private JLabel lblLodging;
   //Text Fields
   private JTextField txtDays;
   private JTextField txtAirfare;
   private JTextField txtRental;
   private JTextField txtMiles;
   private JTextField txtParking;
   private JTextField txtTaxi;
   private JTextField txtConference;
   private JTextField txtLodging;
   //Buttons
   private JButton btnClear;
   private JButton btnCalc;
   //End Expenses WIndow
   //---------------------

   public TravelExpenses()
   {
      //Create Window
      setTitle("Travel Expenses");
      setSize(WINDOW_WIDTH,WINDOW_HEIGHT);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
      //Content Pane
      buildContentInfo();
      add(contentPane,BorderLayout.CENTER);
      //BUTTONS!!!
      buildPanButton();
      add(panButtons,BorderLayout.SOUTH);
   }
   /**This method will create the main content pane*/
   private void buildContentInfo()
   {
      contentPane = new JPanel();
      contentPane.setLayout(new GridLayout(8,2));
      setLayout(new BorderLayout());
      lblDays = new JLabel("Number of days on Trip:");
      lblAirfare = new JLabel("Amount of Airfare:");
      lblRental = new JLabel("Amount of Car Rental:");
      lblMiles = new JLabel("Miles Driven:");
      lblParking = new JLabel("Parking Fees:");
      lblTaxi = new JLabel("Taxi Fees:");
      lblConference = new JLabel("Conference Registration:");
      lblLodging = new JLabel("Lodging charges per night:");
      txtDays = new JTextField(10);
      txtAirfare = new JTextField(10);
      txtRental = new JTextField(10);
      txtMiles = new JTextField(10);
      txtParking = new JTextField(10);
      txtTaxi = new JTextField(10);
      txtConference = new JTextField(10);
      txtLodging = new JTextField(10);
      contentPane.add(lblDays);
      contentPane.add(txtDays);
      contentPane.add(lblAirfare);
      contentPane.add(txtAirfare);
      contentPane.add(lblRental);
      contentPane.add(txtRental);
      contentPane.add(lblMiles);
      contentPane.add(txtMiles);
      contentPane.add(lblParking);
      contentPane.add(txtParking);
      contentPane.add(lblTaxi);
      contentPane.add(txtTaxi);
      contentPane.add(lblConference);
      contentPane.add(txtConference);
      contentPane.add(lblLodging);
      contentPane.add(txtLodging);  
   }
   /**This method will create the bottom panel*/
   private void buildPanButton()
   {
      panButtons = new JPanel();
      panButtons.setLayout(new FlowLayout());
      btnClear = new JButton("Clear");
      btnClear.addActionListener(new ButtonListener());
      btnCalc = new JButton("Calculate");
      btnCalc.addActionListener(new ButtonListener());
      
      //add buttons
      panButtons.add(btnClear);
      panButtons.add(btnCalc);
   }
   /**This method will clear the text fields
   */
   private void clearText()
   {
      txtDays.setText("");
      txtAirfare.setText("");
      txtMiles.setText("");
      txtParking.setText("");
      txtTaxi.setText("");
      txtRental.setText("");
      txtConference.setText("");
      txtLodging.setText("");
   }
   /**This method will calculate the totals.
   It will then display them in a dialog box.
   */
   private void calcTotals()
   {
      int    intDays = Integer.parseInt(txtDays.getText());
      double dblAirfare = Double.parseDouble(txtAirfare.getText());
      double dblRental = Double.parseDouble(txtRental.getText());
      double dblMiles = Double.parseDouble(txtMiles.getText());
      double dblParking = Double.parseDouble(txtParking.getText());
      double dblTaxi = Double.parseDouble(txtTaxi.getText());
      double dblConference = Double.parseDouble(txtConference.getText());
      double dblLodging = Double.parseDouble(txtLodging.getText());
      double travel;
      double total;
      double allowable;
      double returned;
      String spentStatus;
      DecimalFormat dollar = new DecimalFormat("$0.00");
      
      if(dblRental !=0)
      {
         travel = 0.27 * dblMiles;
      }
      else
      {
         travel = 20.0*intDays;
      }
      
      total = dblAirfare + dblRental + dblParking + 
              dblTaxi + dblConference + dblLodging*intDays;
      allowable = 17.0*intDays + 10.0*intDays + travel +
                  95.0*intDays; 
      
      if(total <= allowable)
      {
         spentStatus = "You saved the company: " +
                        dollar.format(allowable - total);
      }
      else
      {
         spentStatus = "You owe: " +
                        dollar.format(total-allowable);
      }
      
      JOptionPane.showMessageDialog(null,"Total Expense: " + dollar.format(total) + "\n"
                                   +"Allowable Expenses: " + dollar.format(allowable) + "\n"
                                   +spentStatus);
      
   }
   private class ButtonListener implements ActionListener
   {
      public void actionPerformed (ActionEvent event)
      {
         String whichButton = event.getActionCommand();
         if(whichButton.equals("Clear"))
         {
            clearText();
         }
         else if (whichButton.equals("Calculate"))
         {
            calcTotals();
         }
      }
   }
   public static void main(String[] args)
   {
      TravelExpenses travel = new TravelExpenses();
      travel.setVisible(true);
   }

}