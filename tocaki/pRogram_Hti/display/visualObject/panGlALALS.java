// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.awt.GridLayout;
import java.util.ArrayList;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class panGlALALS extends JPanel
{
    public static final long serialVersionUID = 1L;
    public ArrayList<ArrayList<String>> ALALS;
    
    public panGlALALS(final ArrayList<ArrayList<String>> ALALS) {
        this.ALALS = new ArrayList<ArrayList<String>>();
        this.ALALS = ALALS;
        this.bwild();
    }
    
    public void bwild() {
        this.removeAll();
        this.setLayout(new GridLayout(this.ALALS.size(), 1));
        for (final ArrayList<String> ALS : this.ALALS) {
            final JPanel JP = new JPanel();
            JP.setLayout(new GridLayout(ALS.size() + 1, 1));
            for (final Object O : ALS) {
                JP.add(new JLabel((String)O));
            }
            JP.add(new JLabel(" "));
            this.add(JP);
        }
    }
}
