namespace LeitorNfe.Utils;

public class XMLUtils
{
    public string GetFilePath()
    {
        string folderPath = "wwwroot/storage/nfe";
        return Path.Combine(folderPath, GetUniqueFileName(folderPath, "xml"));
    }

    public string GetUniqueFileName(string folderPath, string extension)
    {
        int number = 1;
        string newFileName = $"{number}.{extension}";
        while (File.Exists(Path.Combine(folderPath, newFileName)))
        {
            number++;
            newFileName = $"{number}.{extension}";
        }
        return newFileName;
    }

}