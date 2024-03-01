// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.algoritm.jeneratLR;

import java.util.ArrayList;

public abstract class kMbinezM
{
    public static ArrayList<String> jenGrkMbinezMrekursif(final ArrayList<ArrayList<String>> ALALS) {
        final ArrayList<String> ALS = new ArrayList<String>();
        final String S = "";
        apGlrekursif(S, ALALS, 0, ALS);
        return ALS;
    }
    
    private static void apGlrekursif(final String S, final ArrayList<ArrayList<String>> ALALS, final int etaj, final ArrayList<String> rezult) {
        final int l = ALALS.get(etaj).size();
        if (etaj < ALALS.size() - 1) {
            for (int i = 0; i < l; ++i) {
                final String S2 = S + ALALS.get(etaj).get(i);
                apGlrekursif(S2, ALALS, etaj + 1, rezult);
            }
        }
        else {
            for (int i = 0; i < l; ++i) {
                final String S3 = S + ALALS.get(etaj).get(i);
                rezult.add(S3);
            }
        }
    }
    
    public static ArrayList<String> jenGrkMbinezMiteratif(final ArrayList<ArrayList<String>> ALALS) {
        final int n = ALALS.size();
        final int[] bDrn = new int[n];
        for (int i = 0; i < n; ++i) {
            bDrn[i] = ALALS.get(i).size() - 1;
        }
        final int[] kMtLR = new int[n];
        final ArrayList<String> ALS = new ArrayList<String>();
        while (kMtLR[0] <= bDrn[0]) {
            String S = "";
            for (int j = 0; j < n; ++j) {
                S = S + ALALS.get(j).get(kMtLR[j]);
            }
            ALS.add(S);
            final int[] array = kMtLR;
            final int n2 = n - 1;
            ++array[n2];
            for (int j = n - 1; j > 0; --j) {
                if (kMtLR[j] <= bDrn[j]) {
                    break;
                }
                kMtLR[j] = 0;
                final int[] array2 = kMtLR;
                final int n3 = j - 1;
                ++array2[n3];
            }
        }
        return ALS;
    }
}
