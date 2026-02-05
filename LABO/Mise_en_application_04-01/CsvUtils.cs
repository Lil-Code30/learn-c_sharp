
using System.Reflection;

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
            var tabHeader = new List<string>();

            // list of rows for the table content
            List<string[]> tabBody = new List<string[]>();

            using ( StreamReader reader = new StreamReader(filePath))
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} does not exist");
                    return;
                }
                var lines = File.ReadAllLines(filePath).ToList();
                int fileContentLenght = lines.Count;
                
                // getting the header from the file
                string[] headers = lines[0].Split(",");

                // adding the header in the Table header list
                foreach (var h in headers)
                {
                    tabHeader.Add(h);
                }

                // fetching the rest of the file data and adding them to the table body
                for (int i = 1; i < fileContentLenght; i++)
                {
                    var tabBodyLine = lines[i].Split(",");

                    // here each file line is a row content for the table
                    tabBody.Add(tabBodyLine);
                }


                Console.WriteLine("Displaying content from the csv file into a table");
                Console.WriteLine();
                Console.WriteLine("+----+----------+------------+--------+-------+------------+--------+-------+------------+");
                Console.Write($"| ID |");
                for (int i = 0; i < headers.Length; i++)
                {
                    Console.Write($"| {headers[i]}    |");
                }
                Console.WriteLine();
                Console.WriteLine("+----+----------+------------+--------+-------+------------+--------+-------+------------+");

                int rowNum = 1;

                // Displaying the csv content in a table format
                foreach (var row in tabBody)
                {
                   
                    Console.Write($"| {rowNum} ");

                    for (int i = 0; i < row.Length; i++)
                    {

                        Console.Write($"| {row[i]}    |");

                    }

                    rowNum++;
                    Console.WriteLine();
                }
                Console.WriteLine("+----+----------+------------+--------+-------+------------+--------+-------+------------+");

            }
        }
       
    }
}
