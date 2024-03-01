// 
// Decompiled by Procyon v0.5.36
// 
package logicalClass;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.JFileChooser;
public abstract class tools{
	public static ArrayList<String> File_to_ALS(final File F) throws IOException{
		if(F!=null){
			final ArrayList<String> ALS=new ArrayList<String>();
			final InputStream IS=new FileInputStream(F);
			final InputStreamReader ISR=new InputStreamReader(IS);
			final BufferedReader BR=new BufferedReader(ISR);
			String S;
			while((S=BR.readLine())!=null){
				ALS.add(S);
			}
			BR.close();
			return ALS;
		}
		return null;
	}
	public static String File_tH_String(final File F) throws IOException{
		if(F!=null){
			String S="";
			final InputStream IS=new FileInputStream(F);
			final InputStreamReader ISR=new InputStreamReader(IS);
			final BufferedReader BR=new BufferedReader(ISR);
			String S2;
			while((S2=BR.readLine())!=null){
				S= S +S2+"\n";
			}
			BR.close();
			return S;
		}
		return null;
	}
	public static ArrayList<ArrayList<String>> transform_ALS_to_ALALS(final ArrayList<String> ALS){
		final ArrayList<ArrayList<String>> ALALS=new ArrayList<ArrayList<String>>();
		for(final String S:ALS){
			final ArrayList<String> ALS2=new ArrayList<String>();
			ALS2.add(S);
			ALALS.add(ALS2);
		}
		return ALALS;
	}
	public static ArrayList<ArrayList<String>> cut_ALS_To_ALALS(final ArrayList<String> ALS){
		final ArrayList<ArrayList<String>> ALALS=new ArrayList<ArrayList<String>>();
		for(final String S:ALS){
			final ArrayList<String> ALS2=new ArrayList<String>();
			for(int l=S.length(),i=0;i<l;++i){
				ALS2.add(S.substring(i,i+1));
			}
			ALALS.add(ALS2);
		}
		return ALALS;
	}
	public static File import_File() throws Exception{
		final JFileChooser JFC=new JFileChooser(new File(System.getProperty("user.dir")));
		if(JFC.showOpenDialog(null)==0){
			return JFC.getSelectedFile();
		}
		return null;
	}
	public static void ALS_to_file_manual(final ArrayList<String> ALS) throws IOException{
		final JFileChooser JFC=new JFileChooser(new File(System.getProperty("user.dir")));
		JFC.setDialogTitle("ArEjistRe la list aktuGl");
		if(JFC.showSaveDialog(null)==0){
			ALS_to_file(ALS,JFC.getSelectedFile().getAbsolutePath());
		}
	}
	public static void ALS_to_file(final ArrayList<String> ALS,final String path) throws IOException{
		final File F=new File(path);
		final PrintWriter PW=new PrintWriter(new BufferedWriter(new FileWriter(F)));
		for(final String S:ALS){
			PW.println(S);
		}
		PW.close();
	}
	public static ArrayList<Character> ALC_dE_String(final String S){
		final ArrayList<Character> rezult=new ArrayList<Character>();
		for(int l=S.length(),i=0;i<l;++i){
			rezult.add(S.charAt(i));
		}
		return rezult;
	}
	public static String String_qtace_to_String_FR(final String S){
		final ArrayList<Character> inpHt=ALC_dE_String(S);
		String rezult="";
		final int l=inpHt.size();
		for(final Character C:inpHt) {
			switch (C) {
				case '$': {
					rezult = rezult + "gn";
					continue;
				}
				case 'R': {
					rezult = rezult + "r";
					continue;
				}
				case 'r': {
					rezult = rezult + "r";
					continue;
				}
				case '&': {
					rezult = rezult + "r";
					continue;
				}
				case 'c': {
					rezult = rezult + "l";
					continue;
				}
				case '\u20ac': {
					rezult = rezult + "sh";
					continue;
				}
				case 'S': {
					rezult = rezult + "th";
					continue;
				}
				case 'q': {
					rezult = rezult + "ch";
					continue;
				}
				case 'o': {
					rezult = rezult + "au";
					continue;
				}
				case 'D': {
					rezult = rezult + "o";
					continue;
				}
				case 'M': {
					rezult = rezult + "on";
					continue;
				}
				case 'E': {
					rezult = rezult + "e";
					continue;
				}
				case 'e': {
					rezult = rezult + "\u00e9";
					continue;
				}
				case '\u00e8': {
					rezult = rezult + "G";
					continue;
				}
				case 'L': {
					rezult = rezult + "eu";
					continue;
				}
				case 'u': {
					rezult = rezult + "u";
					continue;
				}
				case 'U': {
					rezult = rezult + "u";
					continue;
				}
				case 'N': {
					rezult = rezult + "in";
					continue;
				}
				case 'A': {
					rezult = rezult + "en";
					continue;
				}
				case 'µ': {
					rezult = rezult + "un";
					continue;
				}
				default: {
					rezult = rezult + C;
					continue;
				}
			}
		}
		for(int i=0;i<l;++i){}
		return rezult;
	}
	public static ArrayList<Object> mix_ALO(final ArrayList<Object> ALO){
		final Random R=new Random();
		for(int i=0;i<ALO.size();++i){
			final Object memwar=ALO.get(i);
			final int alea=R.nextInt(ALO.size());
			ALO.set(i,ALO.get(alea));
			ALO.set(alea,memwar);
		}
		return ALO;
	}
	public static ArrayList<String> File_to_ALS_manual(){
		ArrayList<String> ALS=new ArrayList<String>();
		final JFileChooser JFC=new JFileChooser(new File("tmp/"));
		JFC.setDialogTitle("ArEjistRe la list aktuGl");
		if(JFC.showSaveDialog(null)==0){
			try{
				ALS=File_to_ALS(new File(JFC.getSelectedFile().getAbsolutePath()));
			}catch(IOException e){
				e.printStackTrace();
			}
		}
		return ALS;
	}
}
