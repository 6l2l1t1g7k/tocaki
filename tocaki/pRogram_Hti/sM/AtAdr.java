// 
// Decompiled by Procyon v0.5.36
// 

package sM;

import javax.sound.sampled.LineUnavailableException;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.DataLine;
import javax.sound.sampled.AudioFormat;
import java.io.File;
import java.io.IOException;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioFileFormat;
import javax.sound.sampled.TargetDataLine;

public class AtAdr extends Thread
{
    public final TargetDataLine line;
    public final AudioFileFormat.Type targetType;
    public final AudioInputStream inputStream;
    public File file;
    
    public AtAdr(String a) throws LineUnavailableException {
        this.targetType = AudioFileFormat.Type.WAVE;
        final AudioFormat audioFormat = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED, 44100.0f, 16, 2, 4, 44100.0f, false);
        final DataLine.Info info = new DataLine.Info(TargetDataLine.class, audioFormat);
        (this.line = (TargetDataLine)AudioSystem.getLine(info)).open(audioFormat);
        this.inputStream = new AudioInputStream(this.line);
        a = "tmp/" + a;
        this.file = new File(a);
    }
    
    public void startRecording() {
        this.line.start();
        this.start();
    }
    
    public void stopRecording() {
        this.line.stop();
        this.line.close();
    }
    
    @Override
    public void run() {
        try {
            AudioSystem.write(this.inputStream, this.targetType, this.file);
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }
    
    public String getPath() {
        return this.file.getAbsolutePath();
    }
    
    public void M_artjvs3r() throws InterruptedException {
        System.out.println("Usage: Hti Recorder <filename>\nDefault file will be used\n");
        System.out.println("d\ufffdmarage de l'\ufffdcoute");
        this.startRecording();
        Thread.sleep(3000L);
        this.stopRecording();
        System.out.println("Recording complete : " + this.getPath());
    }
}
