// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.algoritm;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import logicalClass.tools;

public abstract class text_sequensor
{
    public static void refactor() throws Exception {
        final File F = tools.import_File();
        if (F != null) {
            final ArrayList<String> ALS = new ArrayList<String>();
            final InputStream IS = new FileInputStream(F);
            final InputStreamReader ISR = new InputStreamReader(IS);
            final BufferedReader BR = new BufferedReader(ISR);
            String S = "";
            final char separator1 = ' ';
            final char separator2 = '-';
            String lineToken;
            while ((lineToken = BR.readLine()) != null) {
                for (int end = lineToken.length() - 1, i = 0; i <= end; ++i) {
                    char token = lineToken.charAt(i);
                    if (token == separator1) {
                        if (++i <= end) {
                            token = lineToken.charAt(i);
                        }
                        if (token == separator2) {
                            ALS.add(S);
                            S = "";
                            if (++i <= end) {
                                token = lineToken.charAt(i);
                            }
                        }
                        else {
                            S = S + " " + token;
                        }
                    }
                    else {
                        S = S + token;
                    }
                }
                if (S != "") {
                    ALS.add(S);
                    S = "";
                }
            }
            tools.ALS_to_file_manual(ALS);
            BR.close();
        }
    }
}
