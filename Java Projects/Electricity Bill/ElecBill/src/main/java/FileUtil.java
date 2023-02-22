import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.List;

public class FileUtil {
    public static String[] readLines(String fileName)
    {
        List<String> lines = new ArrayList<String>();
        try
        {
            File file = new File(fileName);
            BufferedReader reader = new BufferedReader(new FileReader(file));
            String readLine = null;
            while ((readLine = reader.readLine()) != null) {lines.add(readLine);}
            reader.close();
            return lines.toArray(new String[lines.size()]);
        }
        catch (Exception e) {return new String[0];}
    }

    public static boolean appendLine(String fileName, String line)
    {
        try
        {
            File file = new File(fileName);
            BufferedWriter writer = new BufferedWriter(new FileWriter(file, true));
            writer.append(line);
            writer.newLine();
            writer.close();
            return true;
        }
        catch(Exception e) {return false;}
    }
}
