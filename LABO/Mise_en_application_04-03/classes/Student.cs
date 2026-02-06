namespace Mise_en_application_04_03.classes;

public class Student
{
   
        // "Nom", "Prénom", "Âge", "Cycle", "Spécialité", "Université"
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Cycle { get; set; }
        public string Specialite { get; set; }
        public string Universite { get; set; }

        public Student(string nom, string prenom, int age, string cycle, string specialite, string universite)
        {
                Nom = nom;
                Prenom = prenom;
                Age = age;
                Cycle = cycle;
                Specialite = specialite;
                Universite = universite;
                
        }

    
}