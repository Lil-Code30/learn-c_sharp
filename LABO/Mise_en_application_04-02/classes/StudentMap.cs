using CsvHelper.Configuration;

namespace Mise_en_application_04_02.classes
{
    public sealed class StudentMap : ClassMap<Student>
    {
         // "Nom", "Prénom", "Âge", "Cycle", "Spécialité", "Université"
        public StudentMap()
        {
            Map(m => m.Nom);
            Map(m => m.Prenom);
            Map(m => m.Age);
            Map(m => m.Cycle);
            Map(m => m.Specialite);
            Map(m => m.Universite);
        }
    }
}
