package display.visualObject;

import java.io.IOException;
import logicalClass.tools;
import java.io.File;
import java.util.ArrayList;

public class FusionSortManager
{
    public ArrayList<ArrayList<ArrayList<String>>> coupleOfListForSort;
    public int sayzDfseluldGstinasyM;
    public boolean finish;
    
    private void init() {
        this.finish = false;
        (this.coupleOfListForSort = new ArrayList<ArrayList<ArrayList<String>>>()).add(new ArrayList<ArrayList<String>>());
        this.coupleOfListForSort.add(new ArrayList<ArrayList<String>>());
        final ArrayList<ArrayList<String>> destinationList = new ArrayList<ArrayList<String>>();
        destinationList.add(new ArrayList<String>());
        this.coupleOfListForSort.add(2, destinationList);
        this.sayzDfseluldGstinasyM = 2;
    }
    
    public FusionSortManager(final File F) throws IOException {
        this.init();
        this.coupleOfListForSort.set(1, tools.transform_ALS_to_ALALS(tools.File_to_ALS(F)));
    }
    
    public FusionSortManager(final ArrayList<String> ALS) throws IOException {
        this.init();
        this.coupleOfListForSort.set(1, tools.transform_ALS_to_ALALS(ALS));
    }
    
    public void rifrGq_dGstinasyM() {
        final ArrayList<ArrayList<String>> listdGstinasyM = new ArrayList<ArrayList<String>>();
        listdGstinasyM.add(new ArrayList<String>());
        this.coupleOfListForSort.set(2, listdGstinasyM);
        this.sayzDfseluldGstinasyM *= 2;
    }
    
    public void choose(final int qwa) {
        if (!this.finish) {
            ArrayList<String> selulAkHR = this.coupleOfListForSort.get(2).get(this.coupleOfListForSort.get(2).size() - 1);
            if (selulAkHR.size() >= this.sayzDfseluldGstinasyM) {
                this.coupleOfListForSort.get(2).add(new ArrayList<String>());
                selulAkHR = this.coupleOfListForSort.get(2).get(this.coupleOfListForSort.get(2).size() - 1);
            }
            if (qwa == 1) {
                selulAkHR.add(this.coupleOfListForSort.get(1).get(0).get(0));
                this.coupleOfListForSort.get(1).get(0).remove(0);
            }
            else {
                selulAkHR.add(this.coupleOfListForSort.get(1).get(1).get(0));
                this.coupleOfListForSort.get(1).get(1).remove(0);
            }
            if (this.coupleOfListForSort.get(1).get(0).size() == 0) {
                for (final String S : this.coupleOfListForSort.get(1).get(1)) {
                    selulAkHR.add(S);
                }
                this.coupleOfListForSort.get(1).remove(0);
                this.coupleOfListForSort.get(1).remove(0);
            }
            else if (this.coupleOfListForSort.get(1).get(1).size() == 0) {
                for (final String S : this.coupleOfListForSort.get(1).get(0)) {
                    selulAkHR.add(S);
                }
                this.coupleOfListForSort.get(1).remove(0);
                this.coupleOfListForSort.get(1).remove(0);
            }
            switch (this.coupleOfListForSort.get(1).size()) {
                case 0: {
                    this.coupleOfListForSort.set(1, this.coupleOfListForSort.get(2));
                    this.rifrGq_dGstinasyM();
                    break;
                }
                case 1: {
                    this.coupleOfListForSort.get(2).add(this.coupleOfListForSort.get(1).get(0));
                    this.coupleOfListForSort.set(1, this.coupleOfListForSort.get(2));
                    this.rifrGq_dGstinasyM();
                    break;
                }
            }
        }
        if (this.coupleOfListForSort.get(1).size() < 2) {
            this.finish = true;
        }
    }
    
    public ArrayList<Object> get_next_couple() {
        final ArrayList<Object> ALO2 = new ArrayList<Object>();
        if (!this.finish) {
            ALO2.add(this.coupleOfListForSort.get(1).get(0).get(0));
            ALO2.add(this.coupleOfListForSort.get(1).get(1).get(0));
        }
        else {
            ALO2.add("fini");
            ALO2.add("fini");
        }
        return ALO2;
    }
}
