// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject.window;

import javax.swing.JOptionPane;
import java.io.File;
import logicalClass.algoritm.jeneratLR.mo_aleatwar;
import javax.swing.JLabel;
import logicalClass.tools;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import java.awt.GridLayout;
import javax.swing.JPanel;
import javax.swing.JSplitPane;
import javax.swing.JTextArea;
import display.ekritur.alfabe;
import javax.swing.JFrame;

public class lNgwistik extends JFrame
{
    private static final long serialVersionUID = 8783990311153165628L;
    public alfabe alf;
    public JTextArea JTA1;
    public JTextArea JTA2;
    public JTextArea JTA3;
    
    public lNgwistik() {
        this.init();
    }
    
    public void init() {
        this.setVisible(true);
        this.setTitle("moaleatwar");
        this.setSize(1000, 600);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(2);
        final JSplitPane JSP1 = new JSplitPane(0);
        this.setContentPane(JSP1);
        JSP1.setResizeWeight(0.2);
        JSP1.setDividerSize(1);
        final JPanel JP = new JPanel();
        JP.setLayout(new GridLayout(3, 2));
        JButton JB = new JButton("qarje(alfabe)");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    lNgwistik.this.alf = new alfabe(tools.import_File());
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JP.add(JB);
        JP.add(new JButton());
        JP.add(new JLabel("nMbr(fonGm)"));
        JP.add(new JLabel("struktur(fonGm)"));
        JP.add(this.JTA1 = new JTextArea("4"));
        JP.add(this.JTA2 = new JTextArea("struktur(fonGm)"));
        JSP1.setTopComponent(JP);
        final JSplitPane JSP2 = new JSplitPane(1);
        JSP2.setResizeWeight(0.2);
        JSP2.setDividerSize(5);
        (this.JTA3 = new JTextArea("ryN")).setAutoscrolls(true);
        this.JTA3.setLineWrap(true);
        JSP2.setRightComponent(this.JTA3);
        JB = new JButton("jenGr");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    final int i = Integer.parseInt(lNgwistik.this.JTA1.getText());
                    lNgwistik.this.JTA3.setText(mo_aleatwar.jenGrmo(lNgwistik.this.alf, i));
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JSP2.setLeftComponent(JB);
        JSP1.setBottomComponent(JSP2);
        try {
            this.alf = new alfabe(new File("bd/alfabe(tocaki).txt"));
        }
        catch (Exception e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(null, "File:bd/alfabe(tocaki).txt\nerLR\nFile ¬qarje\u2192¬(alfabe)", "erLR", 0);
        }
    }
}
