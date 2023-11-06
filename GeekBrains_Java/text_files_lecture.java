import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
public class text_files_lecture {
    public static void main(String[] args) throws Exception { // throws exception if we do not add try-catch block
        try (FileWriter fw = new FileWriter("file.txt", false))
        {
            fw.write("line 1");
            fw.append('\n');
            fw.append('2');
            fw.append('\n');
            fw.write("line 3");
            fw.flush();
        }
        catch (IOException ex)
        {
            System.out.println("File opening aborted:" + ex.getMessage());
            // if write rights are limited 
        }
        // Read character by character
        FileReader fr = new FileReader("file.txt");
        int c;
        while ((c = fr.read()) != -1)
        {
            char ch = (char) c;
            if (ch == '\n')
                System.out.print(ch);
            else
            {
                System.out.print(ch);
            }
        }
        System.out.println();
        fr.close();
        //read line by line
        BufferedReader br = new BufferedReader(new FileReader("file.txt"));
        String str;
        while ((str = br.readLine()) != null)
        {
            System.out.printf("== %s == \n", str);
        }
        br.close();
    }    
}
