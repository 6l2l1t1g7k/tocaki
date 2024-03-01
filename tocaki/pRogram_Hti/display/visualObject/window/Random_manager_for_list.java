// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject.window;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JSplitPane;
import javax.swing.JTextArea;
import logicalClass.tools;

public class Random_manager_for_list extends JFrame
{
    private static final long serialVersionUID = -3782979681589270590L;
    public ArrayList<String> itemList;
    public JTextArea itemListPrinter;
    public JTextArea itemLine;
    public Random randomSeed;
    public ArrayList<ArrayList<String>> savedList;
    
    public Random_manager_for_list() throws IOException {
        this.init();
    }
    
    public void init() throws IOException {
        this.setVisible(true);
        this.setTitle("jGstyonGr daleatwar");
        this.setSize(1000, 600);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(2);
        final JSplitPane mainPanel = new JSplitPane(0);
        this.setContentPane(mainPanel);
        mainPanel.setResizeWeight(0.02);
        mainPanel.setDividerSize(1);
        final JPanel JP = new JPanel();
        mainPanel.setTopComponent(JP);
        JP.setLayout(new GridLayout(1, 4));
        JButton JB = new JButton("tRiye la list");
        JP.add(JB);
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    Random_manager_for_list.this.sortTheList();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JB = new JButton("ArEjistRe");
        JP.add(JB);
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    Random_manager_for_list.this.save();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JB = new JButton("selGksyone µ nDbje aleatwar");
        JP.add(JB);
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    Random_manager_for_list.this.selectRandomItem();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JB = new JButton("NpDRte un list");
        JP.add(JB);
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    Random_manager_for_list.this.importListFromOutside(tools.import_File());
                    Random_manager_for_list.this.save();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        final JSplitPane JSP2 = new JSplitPane(1);
        mainPanel.setBottomComponent(JSP2);
        JSP2.setDividerLocation(30);
        JSP2.setDividerSize(1);
        JSP2.setRightComponent(this.itemListPrinter = new JTextArea());
        this.itemListPrinter.setAutoscrolls(true);
        this.itemListPrinter.setLineWrap(true);
        JSP2.setLeftComponent(this.itemLine = new JTextArea());
        this.itemLine.setEditable(false);
        this.itemLine.setLineWrap(true);
        this.setLine();
        this.itemList = new ArrayList<String>();
        this.savedList = new ArrayList<ArrayList<String>>();
        this.randomSeed = new Random();
        final File F = new File("data/list.txt");
        if (F != null) {
            this.importListFromOutside(F);
        }
    }
    
    public void setLine() {
        String S = "";
        for (int end = this.itemListPrinter.getLineCount() - 1, i = 0; i <= end; ++i) {
            S = S + i + "\n";
        }
        this.itemLine.setText(S);
    }
    
    public void save() throws IOException {
        this.setLine();
        this.itemList = new ArrayList<String>();
        final String text = this.itemListPrinter.getText();
        final int end = text.length() - 1;
        String S = "";
        for (int i = 0; i <= end; ++i) {
            final char token = text.charAt(i);
            if (token != '\n') {
                S = S + token;
            }
            else {
                this.itemList.add(S);
                S = "";
            }
        }
        this.itemList.add(S);
        tools.ALS_to_file(this.itemList, "data/list.txt");
    }
    
    public void sortTheList() throws IOException {
        this.save();
        this.itemList.sort(null);
        String text = "";
        for (int end = this.itemList.size() - 2, i = 0; i <= end; ++i) {
            text = text + this.itemList.get(i) + "\n";
        }
        text = text + this.itemList.get(this.itemList.size() - 1);
        this.itemListPrinter.setText(text);
    }
    
    public void selectRandomItem() throws IOException {
        this.save();
        final int bound = this.itemList.size();
        if (bound > 0) {
            final String result = this.itemList.get(this.randomSeed.nextInt(bound));
            JOptionPane.showMessageDialog(null, result, "item aleatwar qwazi", 1);
        }
    }
    
    public void importListFromOutside(final File F) throws IOException {
        if (F != null) {
            this.itemList = tools.File_to_ALS(F);
            String S = "";
            for (int end = this.itemList.size() - 2, i = 0; i <= end; ++i) {
                S = S + this.itemList.get(i) + "\n";
            }
            S = S + this.itemList.get(this.itemList.size() - 1);
            this.itemListPrinter.setText(S);
            this.setLine();
        }
    }
}
