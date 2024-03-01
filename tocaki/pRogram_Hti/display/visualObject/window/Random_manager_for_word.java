// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject.window;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.util.ArrayList;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JSplitPane;
import javax.swing.JTextArea;
import display.ekritur.alfabe;
import logicalClass.tools;
import logicalClass.algoritm.jeneratLR.mo_aleatwar;

public class Random_manager_for_word extends JFrame
{
    private static final long serialVersionUID = -3782979681589270590L;
    public ArrayList<String> itemList;
    public JTextArea itemListPrinter;
    public alfabe alf;
    
    public Random_manager_for_word() {
        this.init();
    }
    
    public void init() {
        this.setVisible(true);
        this.setTitle("jGstyonGr daleatwar");
        this.setSize(1000, 600);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(2);
        final JSplitPane mainPanel = new JSplitPane(0);
        mainPanel.setResizeWeight(0.2);
        mainPanel.setDividerSize(1);
        this.setContentPane(mainPanel);
        try {
            this.alf = new alfabe(new File("bd/alfabe(tocaki).txt"));
        }
        catch (Exception e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(null, "File:bd/alfabe(tocaki).txt\nerLR\nFile ¬qarje\u2192¬(alfabe)", "erLR", 0);
        }
        final JPanel JP = new JPanel();
        JP.setLayout(new GridLayout(3, 2));
        JButton JB = new JButton("qarje 1 list");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    Random_manager_for_word.this.itemList = tools.File_to_ALS(tools.import_File());
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JP.add(JB);
        mainPanel.setTopComponent(JP);
        final JSplitPane JSP2 = new JSplitPane(1);
        JSP2.setResizeWeight(0.2);
        JSP2.setDividerSize(5);
        (this.itemListPrinter = new JTextArea("ryN")).setAutoscrolls(true);
        this.itemListPrinter.setLineWrap(true);
        JSP2.setRightComponent(this.itemListPrinter);
        JB = new JButton("jenGr");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    final int i = Integer.parseInt(Random_manager_for_word.this.itemListPrinter.getText());
                    Random_manager_for_word.this.itemListPrinter.setText(mo_aleatwar.jenGrmo(Random_manager_for_word.this.alf, i));
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JSP2.setLeftComponent(JB);
        mainPanel.setBottomComponent(JSP2);
    }
}
