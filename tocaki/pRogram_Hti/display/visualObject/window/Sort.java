// 
// Decompiled by Procyon v0.5.36
// 
package display.visualObject.window;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.util.ArrayList;
import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JSplitPane;
import javax.swing.KeyStroke;
import display.visualObject.PanelToSortText;
import display.visualObject.panGl_ALS;
import logicalClass.tools;
public class Sort extends JFrame{
	public static final long	serialVersionUID=1L;
	public ArrayList<Object>	A;
	public panGl_ALS			pt;
	public JSplitPane			JSpP;
	public JScrollPane			leftPanel;
	public JScrollPane			rightPanel;
	public PanelToSortText		panelForText;
	public JMenuBar				JMB;
	public JMenu				JM1;
	public JMenu				JM2;
	public JMenu				JM3;
	public JMenuItem			JMI1;
	public JMenuItem			JMI2;
	public JMenuItem			JMI3;
	public JMenuItem			JMI4;
	public JMenuItem			JMI5;
	public JMenuItem			JMI6;
	public JMenuItem			JMI7;
	public Sort() throws Exception{
		this.init();
		this.init_mEnu();
	}
	private void init() throws Exception{
		this.A=new ArrayList<Object>();
		this.JSpP=new JSplitPane();
		this.leftPanel=new JScrollPane();
		this.rightPanel=new JScrollPane();
		this.setVisible(true);
		this.setTitle("tri");
		this.setSize(1000,1000);
		this.setLocationRelativeTo(null);
		this.setDefaultCloseOperation(2);
		this.setContentPane(this.JSpP=new JSplitPane(1));
		this.JSpP.setDividerSize(3);
		this.JSpP.setResizeWeight(0.6);
		this.JSpP.setContinuousLayout(true);
		this.JSpP.setLeftComponent(this.leftPanel);
		this.leftPanel.setVerticalScrollBarPolicy(20);
		this.leftPanel.setHorizontalScrollBarPolicy(30);
		this.JSpP.setRightComponent(this.rightPanel);
		this.rightPanel.setVerticalScrollBarPolicy(20);
		this.rightPanel.setHorizontalScrollBarPolicy(30);
	}
	public void Display_PanelToSortText(final panGl_ALS pt) throws Exception{
		this.panelForText=new PanelToSortText(pt.ALS);
		(this.rightPanel=new JScrollPane(this.panelForText)).setVerticalScrollBarPolicy(20);
		this.rightPanel.setHorizontalScrollBarPolicy(30);
		this.JSpP.setRightComponent(this.rightPanel);
	}
	public void init_mEnu(){
		this.setJMenuBar(this.JMB=new JMenuBar());
		this.JM1=new JMenu("aksyM");
		this.JM2=new JMenu("Gd");
		this.JMB.add(this.JM1);
		this.JMB.add(this.JM2);
		(this.JMI1=new JMenuItem("NpDR_File")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					final File file=tools.import_File();
					if(file!=null){
						Sort.this.pt=new panGl_ALS(tools.File_to_ALS(file));
						(Sort.this.leftPanel=new JScrollPane(Sort.this.pt)).setVerticalScrollBarPolicy(20);
						Sort.this.JSpP.setLeftComponent(Sort.this.leftPanel);
					}
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		this.JMI1.setAccelerator(KeyStroke.getKeyStroke(97,2));
		this.JM1.add(this.JMI1);
		(this.JMI4=new JMenuItem("triye_la_list")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					if(Sort.this.pt!=null){
						Sort.this.Display_PanelToSortText(Sort.this.pt);
					}else{
						JOptionPane.showMessageDialog(null,"il n'y a pas de liste a trier.","Message",0);
					}
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		this.JMI4.setAccelerator(KeyStroke.getKeyStroke(98,2));
		this.JM1.add(this.JMI4);
		(this.JMI7=new JMenuItem("triye_list_jenerik")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					final String S=JOptionPane.showInputDialog(null,"Atre lE nMbr ditGm a trie","kGstyM",3);
					if(S!=null){
						int l=10;
						try{
							l=Integer.parseInt(S);
							final ArrayList<String> ALS=new ArrayList<String>();
							for(int i=1;i<=l;++i){
								ALS.add(new StringBuilder().append(i).toString());
							}
							Sort.this.pt=new panGl_ALS(ALS);
							Sort.this.Display_PanelToSortText(Sort.this.pt);
						}catch(Exception e2){
							JOptionPane.showMessageDialog(null,"ilfodone1int","mesaj",0);
						}
					}
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		this.JMI7.setAccelerator(KeyStroke.getKeyStroke(100,2));
		this.JM1.add(this.JMI7);
		(this.JMI2=new JMenuItem("GkspDRt_sH_fDrma(tGkst)")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					if(Sort.this.panelForText!=null){
						tools.ALS_to_file_manual(Sort.this.panelForText.FSM.coupleOfListForSort.get(1).get(0));
					}else{
						JOptionPane.showMessageDialog(null,"ilnyapadElistaArEjistre","mesaj",0);
					}
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		this.JMI2.setAccelerator(KeyStroke.getKeyStroke(99,2));
		this.JM1.add(this.JMI2);
		(this.JMI3=new JMenuItem("rifrGq_la_fEnGtR")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				Sort.this.repaint();
			}
		});
		this.JMI3.setAccelerator(KeyStroke.getKeyStroke(116,0));
		this.JM1.add(this.JMI3);
		this.JM3=new JMenu("Language");
		this.JM1.add(this.JM3);
		(this.JMI5=new JMenuItem("\u20acooco")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				System.out.println("il faut faire le language \ufffdooco");
			}
		});
		this.JM3.add(this.JMI5);
		(this.JMI6=new JMenuItem("Fran\u00e7ais")).addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				System.out.println("il faut faire le language Fran\ufffdais");
			}
		});
		this.JM3.add(this.JMI6);
	}
}
