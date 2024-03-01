// 
// Decompiled by Procyon v0.5.36
// 

package sM;

public class fonetize implements Runnable
{
    public Thread t;
    public String s;
    
    @Override
    public void run() {
        try {
            for (int i = 100; i > 0; --i) {
                System.out.println("Thread: , " + i);
                Thread.sleep(50L);
            }
        }
        catch (InterruptedException e) {
            System.out.println("Un Thread de la classe C_so s'est interrompu par erreur");
        }
    }
    
    public void start() {
        System.out.println("Starting ");
        if (this.t == null) {
            (this.t = new Thread(this, "blabla")).start();
        }
    }
}
