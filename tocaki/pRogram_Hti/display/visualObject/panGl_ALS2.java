// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.awt.Font;
import java.awt.GridLayout;
import java.util.ArrayList;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JSplitPane;

public class panGl_ALS2 extends JSplitPane
{
    private static final long serialVersionUID = 1L;
    public JPanel JP;
    public panGl_ALS3 pALS3;
    public ArrayList<String> ALS;
    
    public panGl_ALS2(final ArrayList<String> ALS) {
        super(1);
        this.ALS = ALS;
        this.init();
        this.rifrGq();
    }
    
    public void init() {
        this.setRightComponent(this.pALS3 = new panGl_ALS3(this.ALS));
    }
    
    public void rifrGq() {
        (this.JP = new JPanel()).setLayout(new GridLayout(this.ALS.size(), 1));
        for (int i = this.ALS.size(); i > 0; --i) {
            final JLabel JL = new JLabel(new StringBuilder().append(i).toString());
            JL.setFont(new Font("Cambria", 0, 20));
            this.JP.add(JL);
        }
        this.setLeftComponent(this.JP);
        this.setDividerSize(0);
        this.setDividerLocation(50);
        this.pALS3.bwild();
    }
}
