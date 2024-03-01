// 
// Decompiled by Procyon v0.5.36
// 

package diksyonGr;

import java.awt.TextArea;
import java.awt.GridLayout;
import javax.swing.JPanel;
import javax.swing.JFrame;
import java.util.ArrayList;

public class afiqaj
{
    public static void sizawt_ALS(final ArrayList<String> ALS) {
        for (final Object S : ALS) {
            System.out.println(S);
        }
    }
    
    public static void sizawt_ALALS(final ArrayList<ArrayList<String>> ALALS) {
        for (final ArrayList<String> ALS : ALALS) {
            sizawt_ALS(ALS);
        }
    }
    
    public static void print_ALS(final ArrayList<String> ALS) {
        for (int l = ALS.size(), i = 0; i < l; ++i) {
            System.out.println(ALS.get(i));
        }
    }
    
    public static void afiq_matris_2D(final Object[][] tablo) {
        final JFrame JF = new JFrame();
        JF.setVisible(true);
        JF.setTitle("tablo");
        JF.setLocationRelativeTo(null);
        JF.setDefaultCloseOperation(3);
        final JPanel JP = new JPanel();
        JF.setContentPane(JP);
        JP.setLayout(new GridLayout(tablo.length, tablo[0].length));
        for (final Object[] ligne : tablo) {
            Object[] array;
            for (int length2 = (array = ligne).length, k = 0; k < length2; ++k) {
                final Object i = array[k];
                JP.add(new TextArea(new StringBuilder().append(i.toString()).toString()));
            }
        }
    }
    
    public static void sizawt_matris_2D(final Object[][] tablo) {
        for (final Object[] lin$£ : tablo) {
            Object[] array;
            for (int length2 = (array = lin$£).length, j = 0; j < length2; ++j) {
                final Object O = array[j];
                System.out.print(O.toString());
            }
            System.out.println();
        }
    }
}
