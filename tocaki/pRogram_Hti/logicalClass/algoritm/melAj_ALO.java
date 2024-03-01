// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.algoritm;

import java.util.Random;
import java.util.ArrayList;

public abstract class melAj_ALO
{
    public static void ALO(final ArrayList<Object> ALO) {
        final Random r = new Random();
        final int l = ALO.size();
        int j = 0;
        for (int i = 0; i < l; ++i) {
            j = r.nextInt(ALO.size());
            final Object O = ALO.get(i);
            ALO.set(i, ALO.get(j));
            ALO.set(j, O);
        }
    }
}
