// 
// Decompiled by Procyon v0.5.36
// 
package display.visualObject;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import java.awt.GridLayout;
import java.util.ArrayList;
import java.io.File;
import javax.swing.JSplitPane;
import javax.swing.JPanel;
public class PanelToSortText extends JPanel{
	public static final long	serialVersionUID=1L;
	public FusionSortManager	FSM;
	public JSplitPane			JSP;
	public PanelToSortText(final File F) throws Exception{
		this.FSM=new FusionSortManager(F);
		this.build();
	}
	public PanelToSortText(final ArrayList<String> ALS) throws Exception{
		this.FSM=new FusionSortManager(ALS);
		this.build();
	}
	public void build(){
		this.removeAll();
		(this.JSP=new JSplitPane(0)).setResizeWeight(0.2);
		this.JSP.setDividerSize(4);
		this.add(this.JSP);
		final JPanel JP=new JPanel();
		JP.setLayout(new GridLayout(2,1));
		final ArrayList<Object> ALO=this.FSM.get_next_couple();
		// the code guaranty that there are String
		final JButton JB_1=new JButton((String)ALO.get(0));
		final JButton JB_2=new JButton((String)ALO.get(1));
		JB_1.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				PanelToSortText.this.FSM.choose(1);
				PanelToSortText.this.build();
				PanelToSortText.this.repaint();
				PanelToSortText.this.revalidate();
			}
		});
		JB_2.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(final ActionEvent event){
				PanelToSortText.this.FSM.choose(2);
				PanelToSortText.this.build();
				PanelToSortText.this.repaint();
				PanelToSortText.this.revalidate();
			}
		});
		JP.add(JB_1);
		JP.add(JB_2);
		this.JSP.setTopComponent(JP);
		final JSplitPane JSP2=new JSplitPane(0);
		JSP2.setResizeWeight(0.2);
		JSP2.setDividerSize(4);
		this.JSP.setBottomComponent(JSP2);
		final panGlALALS ptd1=new panGlALALS(this.FSM.coupleOfListForSort.get(1));
		JSP2.setTopComponent(ptd1);
		final panGlALALS ptd2=new panGlALALS(this.FSM.coupleOfListForSort.get(2));
		JSP2.setBottomComponent(ptd2);
	}
}
