import java.io.File;
import java.util.ArrayList;

public class git {
	private static ArrayList filelist = new ArrayList(); 
    
    public static void main(String[] args) {
        
        long a = System.currentTimeMillis();
        refreshFileList("/media/volgrp/myproject/git/eclipse_workspace/GITTools/");
        System.out.println(System.currentTimeMillis() - a);
    }
    public static void refreshFileList(String strPath) { 
        File dir = new File(strPath); 
        File[] files = dir.listFiles(); 
        
        if (files == null) 
            return; 
        for (int i = 0; i < files.length; i++) { 
            if (files[i].isDirectory()) { 
                refreshFileList(files[i].getAbsolutePath()); 
            } else { 
                String strFileName = files[i].getAbsolutePath().toLowerCase();
                System.out.println("---"+strFileName);
                filelist.add(files[i].getAbsolutePath());                    
            } 
        } 
    }

}
String cmd = "ls -al";
		Runtime run = Runtime.getRuntime();
		Process pr = run.exec(cmd);
		pr.waitFor();
		BufferedReader buf = new BufferedReader(new InputStreamReader(pr.getInputStream()));
		String line = "";
		while ((line=buf.readLine())!=null) {
			System.out.println(line);
		}
