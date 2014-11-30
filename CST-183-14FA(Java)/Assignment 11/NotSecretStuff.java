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
   private JTextArea theText;
   private JPanel contentPane;
   
   public NotSecretStuff()
   {
      super("Decoder");
      setSize(WIDTH,HEIGHT);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
      Containter contentPane = getContentPane();
      contetnPane.SetLayout(new BorderLayout());
      
      
   }
}