// 
// Decompiled by Procyon v0.5.36
// 
package display.visualObject.window;
import javax.swing.JButton;
import java.awt.Font;
import javax.swing.JLabel;
import java.awt.GridLayout;
import javax.swing.JPanel;
import java.io.IOException;
import javax.swing.JOptionPane;
import javax.swing.KeyStroke;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JMenuItem;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import logicalClass.tools;
import java.io.File;
import display.visualObject.panGl_ALS2;
import java.util.ArrayList;
import javax.swing.JSplitPane;
import javax.swing.JFrame;
public class Ordernisator extends JFrame{
	public static final long	serialVersionUID=1L;
	public JSplitPane			JSP;
	public ArrayList<String>	ALS;
	public panGl_ALS2			pALS2;
	public String				path;
	public Ordernisator() throws Exception{
		this.init();
		this.initmEnu();
	}
	protected void init() throws Exception{
		this.path="bd/DrdonAsLR.txt";
		this.ALS=tools.File_to_ALS(new File(this.path));
		this.setVisible(true);
		this.setTitle("fEnGtR(DrdonAsLR)");
		this.setExtendedState(6);
		this.setLocationRelativeTo(null);
		this.setDefaultCloseOperation(2);
		(this.JSP=new JSplitPane(0)).setDividerLocation(100);
		this.JSP.setDividerSize(0);
		this.pALS2=new panGl_ALS2(this.ALS);
		this.JSP.setBottomComponent(this.pALS2);
		this.setContentPane(this.JSP);
		this.rifrGq();
	}
	protected void initmEnu(){
		final JMenuBar JMB=new JMenuBar();
		final JMenu JM1=new JMenu("aksyM");
		JMenuItem JMI=new JMenuItem("ajHte 1 taq");
		JMI.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					Ordernisator.this.ajHte_1_taq();
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		JMI.setAccelerator(KeyStroke.getKeyStroke(97,2));
		JM1.add(JMI);
		JMB.add(JM1);
		JMI=new JMenuItem("lAse fEnGtr(PrNsipal)");
		JMI.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					new prNsipal();
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		JMI.setAccelerator(KeyStroke.getKeyStroke(97,2));
		JM1.add(JMI);
		JMB.add(JM1);
		final JMenu JM2=new JMenu("Gd");
		JMB.add(JM2);
		this.setJMenuBar(JMB);
	}
	public void ajHte_1_taq() throws IOException{
		final String s=JOptionPane.showInputDialog(null,"nHvGl taq","",3);
		if(s!=""&&s!=null){
			this.ALS.add(0,s);
		}
		this.sGyv();
		this.rifrGq();
	}
	public void sGyv() throws IOException{
		tools.ALS_to_file(this.ALS,this.path);
	}
	public void rifrGq() throws IOException{
		if(this.ALS.size()==0){
			this.ALS.add("nE ryN fGr");
		}
		final JPanel JP=new JPanel();
		JP.setLayout(new GridLayout(1,3));
		final JLabel JL=new JLabel("a fGr :");
		JL.setFont(new Font("Cambria",0,20));
		JP.add(JL);
		final JLabel JL2=new JLabel(this.ALS.get(0));
		JL2.setFont(new Font("Cambria",0,20));
		JP.add(JL2);
		final JPanel JP2=new JPanel();
		JP2.setLayout(new GridLayout(3,1));
		JButton JB=new JButton("+");
		JB.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					Ordernisator.this.ajHte_1_taq();
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		JP2.add(JB);
		JB=new JButton("-");
		JB.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					Ordernisator.this.ALS.remove(0);
					Ordernisator.this.rifrGq();
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		JP2.add(JB);
		JB=new JButton("\ufffd");
		JB.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				try{
					Ordernisator.this.ALS.add(Ordernisator.this.ALS.get(0));
					Ordernisator.this.ALS.remove(0);
					Ordernisator.this.rifrGq();
				}catch(Exception e){
					e.printStackTrace();
				}
			}
		});
		JP2.add(JB);
		JP.add(JP2);
		this.JSP.setTopComponent(JP);
		this.pALS2.rifrGq();
		this.sGyv();
		this.revalidate();
	}
}
