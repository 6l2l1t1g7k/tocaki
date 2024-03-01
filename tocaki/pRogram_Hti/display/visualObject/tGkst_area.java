// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.util.ArrayList;
import javax.swing.JTextArea;

public class tGkst_area extends JTextArea
{
    public static final long serialVersionUID = 1L;
    ArrayList<String> ALS;
    
    public tGkst_area() {
    }
    
    public tGkst_area(final ArrayList<String> ALS) {
        this.ALS = ALS;
    }
    
    public void paintComponent(final Graphics g) {
        final Font font = new Font("Courier", 1, 15);
        g.setFont(font);
        g.setColor(Color.red);
        for (int l = this.ALS.size(), i = 0; i < l; ++i) {
            g.drawString(this.ALS.get(i), 10, i * 15 + 15);
        }
    }
}
