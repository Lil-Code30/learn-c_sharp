using CsvHelper;
using System.Globalization;
using Mise_en_application_04_02.classes;
using CsvHelper.Configuration;

namespace Mise_en_application_04_02
{
    internal class CsvUtils2
    {

        // D’importer des données depuis un fichier CSV.
        public static void CsvReader(string pathFile)
        {
            using (StreamReader reader = new StreamReader(pathFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<StudentMap>();
                var records = csv.GetRecords<Student>();

                Console.WriteLine("+----------+------------+------------+------------+------------+------------+");
                Console.WriteLine("| Nom | Prénom | Âge | Cycle | Spécialité | Université |");
                Console.WriteLine("+----------+------------+------------+------------+------------+------------+");
                foreach (var student in records)
                {
                    Console.WriteLine($"| {student.Nom} | {student.Prenom} | {student.Age} | {student.Cycle} | {student.Specialite} | {student.Universite} |");
                }
                Console.WriteLine("+----------+------------+------------+------------+------------+------------+");
            }

        }

        // D’exporter une liste d’objets en fichier CSV.
        public static void CsvWriter(string filePath, List<Student> list)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<StudentMap>();
                csv.WriteRecords(list);
            }
        }

        // D’ajouter de nouvelles entrées et de mettre à jour un fichier CSV existant.
        public static void CsvAppend(string filePath, List<Student> list)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again
                HasHeaderRecord = false,
            };

            using (var stream = File.Open(filePath, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.Context.RegisterClassMap<StudentMap>();
                csv.WriteRecords(list);
            }

        }
    }
}
