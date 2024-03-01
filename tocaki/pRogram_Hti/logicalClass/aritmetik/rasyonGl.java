// 
// Decompiled by Procyon v0.5.36
// 

package logicalClass.aritmetik;

public class rasyonGl
{
    public int a;
    public int z;
    
    public rasyonGl(final int a) {
        this.a = a;
        this.z = 1;
    }
    
    public rasyonGl(final int a, final int z) {
        this.a = a;
        this.z = z;
    }
    
    public void print() {
        System.out.println(this.a + "/" + this.z);
    }
}
