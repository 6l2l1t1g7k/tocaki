// 
// Decompiled by Procyon v0.5.36
// 

package display.ekritur;

import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.FileInputStream;
import java.io.File;
import java.util.ArrayList;

public class alfabe
{
    public ArrayList<String> kMsDn;
    public ArrayList<String> vwayGl;
    
    public alfabe(final File F) throws IOException {
        if (F != null) {
            this.kMsDn = new ArrayList<String>(); // first line of file is for consonant
            this.vwayGl = new ArrayList<String>(); // second line of file is for vowel
            final BufferedReader BR = new BufferedReader(new InputStreamReader(new FileInputStream(F)));
            String S = "";
            int l = 0;
            S = BR.readLine();
            l = S.length();
            for (int i = 0; i < l; ++i) {
                this.kMsDn.add(new StringBuilder().append(S.charAt(i)).toString());
            }
            S = BR.readLine();
            l = S.length();
            for (int i = 0; i < l; ++i) {
                this.vwayGl.add(new StringBuilder().append(S.charAt(i)).toString());
            }
            BR.close();
        }
    }
}
