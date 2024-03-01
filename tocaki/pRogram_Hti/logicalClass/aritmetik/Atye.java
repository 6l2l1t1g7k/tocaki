// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.aritmetik;

import java.io.File;
import display.ekritur.alfabe;

public class Atye extends asGrsyM
{
    public alfabe e;
    public String O_s;
    
    public Atye(final String s, final File F) throws Exception {
        super(s);
        this.e = new alfabe(F);
    }
    
    public void adisyM(final Atye A) {
        String rGz = "";
        String rGst = "b";
        for (int l = this.max(this.O_s.length(), A.O_s.length()), i = 0; i < l; ++i) {
            if (i % 2 == 0) {
                final String k1 = this.O_s.substring(i, i + 1);
                final String k2 = A.O_s.substring(i, i + 1);
                final String[] tab5 = this.M_1d9s92n_kos2n(k1, rGst);
                final String[] tab6 = this.M_1d9s92n_kos2n(tab5[0], k2);
                rGz = rGz + tab6[0];
                final String[] tab7 = this.M_1d9s92n_vw1y5l(tab5[1], tab6[1]);
                rGst = tab7[0];
            }
            else {
                final String k1 = this.O_s.substring(i, i + 1);
                final String k2 = A.O_s.substring(i, i + 1);
                final String[] tab5 = this.M_1d9s92n_vw1y5l(k1, rGst);
                final String[] tab6 = this.M_1d9s92n_vw1y5l(tab5[0], k2);
                rGz = rGz + tab6[0];
                final String[] tab7 = this.M_1d9s92n_kos2n(tab5[1], tab6[1]);
                rGst = tab7[0];
            }
        }
        rGz = rGz + rGst;
        if (rGz.length() % 2 != 0) {
            rGz = rGz + 0;
        }
        this.O_s = rGz;
    }
    
    public String[] M_1d9s92n_vw1y5l(String S, String S2) {
        final int i = (this.e.vwayGl.indexOf(S) + this.e.vwayGl.indexOf(S2)) % this.e.vwayGl.size();
        final int j = (this.e.vwayGl.indexOf(S) + this.e.vwayGl.indexOf(S2)) / this.e.vwayGl.size();
        S = this.e.vwayGl.get(i);
        S2 = this.e.kMsDn.get(j);
        return new String[]{S, S2};
    }
    
    public String[] M_1d9s92n_kos2n(String S, String S2) {
        final int i = (this.e.kMsDn.indexOf(S) + this.e.kMsDn.indexOf(S2)) % this.e.kMsDn.size();
        final int j = (this.e.kMsDn.indexOf(S) + this.e.kMsDn.indexOf(S2)) / this.e.kMsDn.size();
        S = this.e.kMsDn.get(i);
        S2 = this.e.vwayGl.get(j);
        return new String[]{ S, S2 };
    }
    
    public int max(final int a, final int b) {
        if (a > b) {
            return a;
        }
        return b;
    }
    
    public int min(final int a, final int b) {
        return -this.max(-a, -b);
    }
}
