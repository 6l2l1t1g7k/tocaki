// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.SDD;

import java.util.HashMap;

public class aqmap extends HashMap<Long, Object>
{
    private static final long serialVersionUID = 1L;
    public Long a;
    
    public void add(final Object o) {
        this.put(++this.a, o);
    }
}
