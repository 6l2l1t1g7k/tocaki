// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.algoritm.jeneratLR;

import java.util.Random;
import display.ekritur.alfabe;

public abstract class mo_aleatwar
{
    public static String jenGrfonGm(final alfabe a, final Random r) {
        String s = "";
        s = s + a.kMsDn.get(r.nextInt(a.kMsDn.size()));
        if (r.nextInt(10) > 8) {
            s = s + a.kMsDn.get(r.nextInt(a.kMsDn.size()));
        }
        s = s + a.vwayGl.get(r.nextInt(a.vwayGl.size()));
        return s;
    }
    
    public static String jenGrmo(final alfabe a, int NfonGm) {
        final Random r = new Random();
        String s = "";
        if (r.nextInt(2) > 0) {
            s = s + a.vwayGl.get(r.nextInt(a.vwayGl.size()));
            --NfonGm;
        }
        for (int i = 0; i < NfonGm; ++i) {
            s = s + jenGrfonGm(a, r);
        }
        if (r.nextInt(4) > 2) {
            s = s + a.kMsDn.get(r.nextInt(a.kMsDn.size()));
            if (r.nextInt(2) > 0) {
                s = s + a.kMsDn.get(r.nextInt(a.kMsDn.size()));
            }
        }
        return s;
    }
}
