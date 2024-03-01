// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.awt.Font;
import java.awt.GridLayout;
import java.util.ArrayList;
import javax.swing.JPanel;
import javax.swing.JTextArea;

public class panGl_ALS3 extends JPanel
{
    private static final long serialVersionUID = 1L;
    public ArrayList<String> ALS;
    
    public panGl_ALS3(final ArrayList<String> ALS) {
        this.ALS = ALS;
        this.bwild();
    }
    
    public void bwild() {
        this.removeAll();
        this.setLayout(new GridLayout(this.ALS.size(), 1));
        for (int l = this.ALS.size(), i = 0; i < l; ++i) {
            final JTextArea JTA = new JTextArea(this.ALS.get(i));
            JTA.setFont(new Font("Cambria", 0, 20));
            this.add(JTA);
        }
    }
}
