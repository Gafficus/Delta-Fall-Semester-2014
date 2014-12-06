/*Created by: Nathan Gaffney
CST 183 Java
Assignment12
This will create an applet that wll do something TBD.
*/
import javax.swing.*;
import java.awt.*;

public class MyFirstApplet extends JApplet
{
   public void init()
   {
      JLabel label = new JLabel("Test");
      JButton button = new JButton("JSPERJNGPISRG");
      add(button);
      setLayout(new FlowLayout());
      add(label);
   }
}