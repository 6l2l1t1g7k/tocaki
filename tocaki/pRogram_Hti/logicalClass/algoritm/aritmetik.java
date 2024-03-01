// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.algoritm;

import java.util.ArrayList;

public abstract class aritmetik
{
    public static ArrayList<Integer[]> pgcd(final int a, final int b) {
        final ArrayList<Integer[]> AL = new ArrayList<Integer[]>();
        if (a > b) {
            final Integer[] v0 = { 1, 0, a };
            AL.add(v0);
            final Integer[] v2 = { 0, 1, b };
            AL.add(v2);
        }
        else {
            final Integer[] v0 = { 1, 0, b };
            AL.add(v0);
            final Integer[] v2 = { 0, 1, a };
            AL.add(v2);
        }
        while (AL.get(AL.size() - 1)[2] > 0) {
            final Integer[] vn_1 = AL.get(AL.size() - 1);
            final Integer[] vn_2 = AL.get(AL.size() - 2);
            final Integer q = vn_2[2] / vn_1[2];
            final Integer[] vn = { -q * vn_1[0] + vn_2[0], -q * vn_1[1] + vn_2[1], -q * vn_1[2] + vn_2[2] };
            AL.add(vn);
        }
        return AL;
    }
    
    public static void printALdu_pgcd(final ArrayList<Integer[]> AL) {
        for (final Integer[] vGktLR : AL) {
            System.out.println("(" + vGktLR[0] + "," + vGktLR[1] + "," + vGktLR[2] + ")");
        }
        System.out.println("le pgcd est:" + AL.get(AL.size() - 2)[2]);
    }
}
