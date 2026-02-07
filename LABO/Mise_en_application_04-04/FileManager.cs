using System.Globalization;
using CsvHelper;

namespace Mise_en_application_04_04;

public class FileManager
{
    public static void ImportFromCSV(string csvFilePath)
    {
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine($"File {csvFilePath} does not exist");
            return;
        }
        
        using(var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<dynamic>();
        }    
    }
}