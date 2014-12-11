/*===========================
Created by: Nathan Gaffney
CST 183 Java

============================*/
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
public class NotSecretStuff extends JFrame
{
   public static final int WIDTH = 600;
   public static final int HEIGHT = 300;
   
   //Window Contents
   private JTextField txtLocation;
   private JTextArea txtEnter;
   private JTextArea txtEncrypted;
   private JPanel contentPane;
   
   public NotSecretStuff()
   {
      super("Definitely Not A Decoder");
      setSize(WIDTH,HEIGHT);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
      Container contentPane = getContentPane();
      contentPane.setLayout(new BorderLayout());
      
      
   }
   class MyDocumentListener implements DocumentListener {
    String newline = "\n";
 
    public void insertUpdate(DocumentEvent e) {
        updateLog(e, "inserted into");
    }
    public void removeUpdate(DocumentEvent e) {
        updateLog(e, "removed from");
    }
    public void changedUpdate(DocumentEvent e) {
        //Plain text components do not fire these events
    }

    public void updateLog(DocumentEvent e, String action) {
        Document doc = (Document)e.getDocument();
        int changeLength = e.getLength();
        displayArea.append(
            changeLength + " character" +
            ((changeLength == 1) ? " " : "s ") +
            action + doc.getProperty("name") + "." + newline +
            "  Text length = " + doc.getLength() + newline);
    }
}
   public static void main(String[] args)
  	{
   	NotSecretStuff gui = new NotSecretStuff();
      gui.setVisible(true);
   }
}