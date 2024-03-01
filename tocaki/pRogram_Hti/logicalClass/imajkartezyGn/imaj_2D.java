package logicalClass.imajkartezyGn;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import javax.swing.JPanel;
import diksyonGr.evaluasyM;

public class imaj_2D extends JPanel
{
    private static final long serialVersionUID = -7924599028622650497L;
    BufferedImage p;
    Graphics g;
    
    public imaj_2D(final evaluasyM f, final Double p1, final Double d1, final Double k1, final Double m, final Integer v, final Integer b1) {
        this.p = new BufferedImage(v, b1, 2);
        (this.g = this.p.getGraphics()).setColor(Color.getHSBColor(0.0f, 0.0f, 0.0f));
        this.g.drawLine(0, 0, 0, b1 - 1);
        this.g.drawLine(0, 0, v - 1, 0);
        this.g.drawLine(0, b1 - 1, v - 1, b1 - 1);
        this.g.drawLine(v - 1, 0, v - 1, b1 - 1);
        this.g.drawLine(v / 2, 0, v / 2, b1 - 1);
        this.g.drawLine(0, b1 / 2, v - 1, b1 / 2);
        this.g.drawLine(0, b1 / 2, v - 1, b1 / 2);
        this.g.setColor(Color.getHSBColor(0.0f, 0.0f, 0.5f));
        Integer i = 0;
        final Double p2 = 0.8;
        final Integer t = (int)(v * (1.0 - p2));
        final Integer j = (int)(v * p2);
        for (i = v % 40 / 2; i < v; i += 40) {
            this.g.drawLine(i + 10, t, i + 30, t);
            this.g.drawLine(i + 10, j, i + 30, j);
        }
        final Integer g = (int)(b1 * (1.0 - p2));
        final Integer l = (int)(b1 * p2);
        for (i = b1 % 40 / 2; i < b1; i += 40) {
            this.g.drawLine(g, i + 10, g, i + 30);
            this.g.drawLine(l, i + 10, l, i + 30);
        }
        Double n = 0.0;
        Integer j2 = 0;
        final Double[] n2 = new Double[(int)v];
        for (i = 0; i < v; ++i) {
            n2[i] = 0.0;
        }
        for (i = 1; i < t; ++i) {
            n = Math.tan((i - (double)t) / (v - j) * 3.141592653589793 / 2.0) + p1;
            n2[i] = f.kalkulnumerik(n);
        }
        Double l2 = (d1 - p1) / (j - t);
        for (i = t; i < j; ++i) {
            n = (i - t) * l2 + p1;
            n2[i] = f.kalkulnumerik(n);
        }
        for (i = j; i < v; ++i) {
            n = Math.tan((i - (double)j) / (v - j) * 3.141592653589793 / 2.0) + d1;
            n2[i] = f.kalkulnumerik(n);
        }
        l2 = (l - g) / (m - k1);
        for (i = 1; i < v; ++i) {
            if (k1 < n2[i] && n2[i] < m) {
                j2 = (int)((n2[i] - k1) * l2 + g);
                this.p.setRGB(i - 1, j2 - 1, -65536);
                this.p.setRGB(i - 1, j2, -65536);
                this.p.setRGB(i - 1, j2 + 1, -65536);
                this.p.setRGB(i, j2 - 1, -65536);
                this.p.setRGB(i, j2, -65536);
                this.p.setRGB(i, j2 + 1, -65536);
                this.p.setRGB(i + 1, j2 - 1, -65536);
                this.p.setRGB(i + 1, j2, -65536);
                this.p.setRGB(i + 1, j2 + 1, -65536);
            }
        }
    }
    
    public void paintComponent(final Graphics g) {
        g.drawImage(this.p, 80, 80, this);
    }
}
