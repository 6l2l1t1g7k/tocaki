// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.awt.Font;
import javax.swing.JLabel;
import java.awt.GridLayout;
import java.util.ArrayList;
import javax.swing.JPanel;

public class panGl_ALS extends JPanel
{
    private static final long serialVersionUID = 1L;
    public ArrayList<String> ALS;
    
    public panGl_ALS(final ArrayList<String> ALS) {
        this.ALS = ALS;
        this.build();
    }
    
    public void build() {
        this.removeAll();
        this.setLayout(new GridLayout(this.ALS.size(), 1));
        for (int l = this.ALS.size(), i = 0; i < l; ++i) {
            final JLabel JL = new JLabel(this.ALS.get(i));
            JL.setFont(new Font("Cambria", 0, 20));
            this.add(JL);
        }
    }
}
