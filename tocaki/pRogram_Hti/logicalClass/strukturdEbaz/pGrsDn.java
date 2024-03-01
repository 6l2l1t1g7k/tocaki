// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.strukturdEbaz;

import java.util.ArrayList;

public class pGrsDn
{
    public ArrayList<konesAs> a;
    
    public boolean savwar(final konesAs a) {
        return this.a.contains(a);
    }
    
    public void kMprAdr(final Object object) {
    }
    
    public void lir(final ArrayList<String> ALS) {
        for (int i = 0; i < ALS.size(); ++i) {
            System.out.println(ALS.get(i));
        }
    }
    
    public void aprAdr(final ArrayList<String> ALS) {
        for (int i = 0; i < ALS.size(); ++i) {
            this.kMprAdr(ALS.get(i));
        }
    }
}
