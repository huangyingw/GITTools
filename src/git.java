import java.io.BufferedReader;
import java.io.File;
import java.io.InputStreamReader;
import java.lang.* ;
import java.util.ArrayList;

public class git {
	
	private static ArrayList filelist = new ArrayList(); 
	public static void main(String[] args) throws Exception{
  	String cmd = "ls -al";
		Runtime run = Runtime.getRuntime();
		Process pr = run.exec(cmd);
		pr.waitFor();
		BufferedReader buf = new BufferedReader(new InputStreamReader(pr.getInputStream()));
		String line = "";
		while ((line=buf.readLine())!=null) {
			System.out.println(line);
			}
   }
}
		
