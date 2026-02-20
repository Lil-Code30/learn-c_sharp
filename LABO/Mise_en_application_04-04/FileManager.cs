using System.Globalization;
using CsvHelper;
namespace Mise_en_application_04_04;

public class FileManager
{
    // D’importer des données depuis un fichier CSV.
    public static IEnumerable<dynamic> ImportCSV(string csvFilePath)
    {
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine($"File {csvFilePath} does not exist");
            throw new FileNotFoundException("File not found", csvFilePath);
        }
        
        IEnumerable<dynamic> recordsList = new List<IEnumerable<dynamic>>();
        using(var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
             recordsList = csv.GetRecords<dynamic>();
        }

        return recordsList;
    }
    
    // D’exporter une liste d’objets en fichier CSV.
    public static void ExportCSV(string csvFilePath, IEnumerable<dynamic> records)
    {
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine($"File {csvFilePath} does not exist");
            throw new FileNotFoundException("File not found", csvFilePath);
        }
        
        using (StreamWriter writer = new StreamWriter(csvFilePath))
        using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(records);
        }
        
        Console.WriteLine($"File {csvFilePath} exported");
    }
}