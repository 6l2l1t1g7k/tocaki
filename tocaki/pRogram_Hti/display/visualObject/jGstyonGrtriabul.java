// 
// Decompiled by Procyon v0.5.36
// 

package display.visualObject;

import java.io.IOException;
import logicalClass.tools;
import java.io.File;
import java.util.ArrayList;

public class jGstyonGrtriabul
{
    public ArrayList<String> listorijin;
    public ArrayList<String> listtrie;
    public boolean fini;
    public int token;
    
    private void init() {
        this.listtrie = new ArrayList<String>();
        this.fini = false;
    }
    
    public jGstyonGrtriabul(final File F) throws IOException {
        this.init();
        this.listtrie = tools.File_to_ALS(F);
    }
    
    public jGstyonGrtriabul(final ArrayList<String> ALS) throws IOException {
        this.init();
        this.listtrie = ALS;
    }
    
    public void qwazi(final int qwa) {
    }
    
    public ArrayList<String> gGt_nGkst_kHpl() {
        final ArrayList<String> ALS2 = new ArrayList<String>();
        if (!this.fini) {
            ALS2.add(this.listtrie.get(this.token));
            ALS2.add(this.listtrie.get(this.token + 1));
        }
        else {
            ALS2.add("fini");
            ALS2.add("fini");
        }
        return ALS2;
    }
}
