// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject.window;

import logicalClass.imajkartezyGn.imaj_2D;
import diksyonGr.evaluasyM;
import java.awt.Color;
import javax.swing.JPanel;
import javax.swing.JFrame;

public class grafdEfMksyM extends JFrame
{
    private static final long serialVersionUID = 1L;
    
    public grafdEfMksyM() {
        this.setVisible(true);
        this.setTitle("5rpf");
        this.setSize(1000, 1000);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(2);
        final JPanel O_p1n5l = new JPanel();
        O_p1n5l.setBackground(Color.getHSBColor(0.8f, 1.0f, 1.0f));
        this.setContentPane(O_p1n5l);
        this.setContentPane(new imaj_2D(new evaluasyM(null), -20.0, 10.0, -10.0, 10.0, 800, 800));
    }
}
