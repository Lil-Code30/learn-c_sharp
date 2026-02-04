using System.IO;

namespace Mise_en_application_04_01
{
    public  class CsvUtils
    {

       public static void CsvWriter(string filePath, string[][] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string[] row in data)
                {
                    string line = string.Join(",", row);
                    writer.WriteLine(line);
                }
            }
        }

        public static void CsvReader(string filePath)
        {
            using( StreamReader reader = new StreamReader(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();

                Console.WriteLine(lines[1]);
                Console.WriteLine(lines.Count);
            }
        }
       
    }
}
