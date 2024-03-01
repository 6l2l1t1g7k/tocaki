// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject.window;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.KeyStroke;
import display.ekritur.alfabe;
import logicalClass.tools;
import logicalClass.algoritm.text_sequensor;
import logicalClass.algoritm.jeneratLR.kMbinezM;

public class prNsipal extends JFrame
{
    public static final long serialVersionUID = 1L;
    public JPanel JP;
    
    public prNsipal() throws Exception {
        this.init();
        this.initbodi();
        this.initmEnu();
        this.revalidate();
    }
    
    public void init() throws Exception {
        this.JP = new JPanel();
        this.setVisible(true);
        this.setTitle("fEnGtr_prNsipal");
        this.setSize(1000, 700);
        this.setLocationRelativeTo(null);
        this.setDefaultCloseOperation(2);
        this.setContentPane(this.JP);
    }
    
    public void initbodi() {
        final ArrayList<JButton> buttonListForGeneralWindow = new ArrayList<JButton>();
        JButton JB = new JButton("fEnGtR(tri)");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Sort();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        JB = new JButton("fEnGtR(graf(Hti))");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new grafdEfMksyM();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        JB = new JButton("fEnGtR(DrdonAsLR)");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Ordernisator();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        JB = new JButton("fEnGtR(lNgwistik)");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new lNgwistik();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        JB = new JButton("fEnGtR(jGstyonGr aleatwar)");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Random_manager_for_word();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        JB = new JButton("Dbje aleatwar dA zun list");
        JB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Random_manager_for_list();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        buttonListForGeneralWindow.add(JB);
        final Iterator<JButton> iterator = buttonListForGeneralWindow.iterator();
        while (iterator.hasNext()) {
            JB = iterator.next();
            this.JP.setLayout(new GridLayout(buttonListForGeneralWindow.size(), 1));
            this.JP.add(JB);
        }
    }
    
    public void initmEnu() {
        final JMenuBar JMB = new JMenuBar();
        this.ajHt_JMenu(JMB);
        this.setJMenuBar(JMB);
    }
    
    public void ajHt_JMenu(final JMenuBar JMB) {
        final JMenu JM = new JMenu("aksyM");
        final JMenu JM2 = new JMenu("fEnGtR");
        JM.add(JM2);
        JMenuItem JMI = new JMenuItem("tri");
        JM2.add(JMI);
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Sort();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(97, 2));
        JMI = new JMenuItem("plotdEfMksyM");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new grafdEfMksyM();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(98, 2));
        JM2.add(JMI);
        JMI = new JMenuItem("Dbje aleatwar dA zun list");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new Random_manager_for_list();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(102, 2));
        JM2.add(JMI);
        final JMenu menu_jenerator = new JMenu("jeneratLR");
        JMI = new JMenuItem("jenGr(kMbinezMrekursif)");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    final alfabe a = new alfabe(tools.import_File());
                    if (a != null) {
                        a.kMsDn.add(0, "");
                        a.vwayGl.add(0, "");
                        final ArrayList<ArrayList<String>> ALALS = new ArrayList<ArrayList<String>>();
                        ALALS.add(a.kMsDn);
                        ALALS.add(a.vwayGl);
                        ALALS.add(a.kMsDn);
                        ALALS.add(a.kMsDn);
                        ALALS.add(a.vwayGl);
                        final ArrayList<String> ALS = kMbinezM.jenGrkMbinezMrekursif(ALALS);
                        tools.ALS_to_file_manual(ALS);
                    }
                }
                catch (Exception ex) {}
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(99, 2));
        menu_jenerator.add(JMI);
        JMI = new JMenuItem("jenGr(kMbinezMiteratif)");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    tools.ALS_to_file_manual(kMbinezM.jenGrkMbinezMiteratif(prNsipal.this.fiqye_vGR_ALALS()));
                }
                catch (Exception ex) {}
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(100, 2));
        menu_jenerator.add(JMI);
        JMI = new JMenuItem("jenGr(moaleatwar)");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    new lNgwistik();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(101, 2));
        menu_jenerator.add(JMI);
        JM.add(menu_jenerator);
        JMB.add(JM);
        final JMenu menu_tools = new JMenu("Hti");
        JM.add(menu_tools);
        JMI = new JMenuItem("sekAsLR dE fiqye");
        JMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    text_sequensor.refactor();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JMI.setAccelerator(KeyStroke.getKeyStroke(102, 2));
        menu_tools.add(JMI);
        JM.add(menu_tools);
        final JMenu JM3 = new JMenu("Gd");
        final JMenuItem JMI2 = new JMenuItem("lisAs");
        JMI2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(final ActionEvent event) {
                try {
                    final JFrame j = new JFrame();
                    j.setVisible(true);
                    j.setTitle("lisAs jeneral£");
                    j.setSize(1200, 1000);
                    j.setLocationRelativeTo(null);
                    j.setDefaultCloseOperation(2);
                    final JPanel JP = new JPanel();
                    final JTextArea JTA = new JTextArea();
                    JTA.setLineWrap(true);
                    JTA.setEditable(false);
                    JTA.setSize(1200, 800);
                    JTA.setText(tools.File_tH_String(new File("LICENCE.TXT")));
                    JP.setLayout(new BorderLayout());
                    JP.add(new JScrollPane(JTA), "Center");
                    j.setContentPane(JP);
                    prNsipal.this.revalidate();
                }
                catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
        JM3.add(JMI2);
        JMB.add(JM3);
    }
    
    public ArrayList<ArrayList<String>> fiqye_vGR_ALALS() throws Exception {
        final ArrayList<ArrayList<String>> ALALS = tools.cut_ALS_To_ALALS(tools.File_to_ALS(tools.import_File()));
        return ALALS;
    }
}
