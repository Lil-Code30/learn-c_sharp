using Mise_en_application_04_02;
using Mise_en_application_04_02.classes;

string[][] students =
{
    new string[] { "Nom", "Prénom", "Âge", "Cycle", "Spécialité", "Université" },
    new string[] { "Bouchard", "Annette", "30", "3ème", "Administration", "UQAR" },
    new string[] { "Tremblay", "Antoine", "20", "1er", "Informatique", "UQAC" },
    new string[] { "Lavoie", "Julien", "25", "2ème", "Ingénierie", "Polytechnique Montréal" },
    new string[] { "Gagnon", "Sophie", "22", "1er", "Médecine", "Université de Montréal" },
    new string[] { "Mercier", "David", "28", "3ème", "Biologie", "Université Laval" }
};

string[][] employees =
{
    new string[] { "Nom", "Prénom", "Fonction", "Entreprise" },
    new string[] { "Deschênes", "Philippe", "Ingénieur IT", "CGI" },
    new string[] { "Desjardins", "Catherine", "Responsable RH", "Desjardins" },
    new string[] { "Leduc", "Vincent", "Analyste Data", "CGI" },
    new string[] { "Tremblay", "Julie", "Chef de projet", "Desjardins" },
    new string[] { "Fortin", "Hugo", "Développeur Web", "Desjardins" }
};

List<Student> studentsList = new List<Student>
{
    new Student
    {
        Nom = "Dupont",
        Prenom = "Jean",
        Age = 20,
        Cycle = "Licence",
        Specialite = "Informatique",
        Universite = "Université de Montréal"
    },
    new Student
    {
        Nom = "Martin",
        Prenom = "Sarah",
        Age = 22,
        Cycle = "Licence",
        Specialite = "Génie logiciel",
        Universite = "UQAM"
    },
    new Student
    {
        Nom = "Nguyen",
        Prenom = "Linh",
        Age = 21,
        Cycle = "Licence",
        Specialite = "Systèmes informatiques",
        Universite = "Université Laval"
    },
    new Student
    {
        Nom = "Diallo",
        Prenom = "Amadou",
        Age = 23,
        Cycle = "Master",
        Specialite = "Data Science",
        Universite = "Université de Sherbrooke"
    },
    new Student
    {
        Nom = "Benali",
        Prenom = "Yasmine",
        Age = 24,
        Cycle = "Master",
        Specialite = "Intelligence Artificielle",
        Universite = "Polytechnique Montréal"
    },
    new Student
    {
        Nom = "Smith",
        Prenom = "Alex",
        Age = 19,
        Cycle = "Licence",
        Specialite = "Informatique",
        Universite = "Concordia University"
    },
    new Student
    {
        Nom = "Tremblay",
        Prenom = "Lucas",
        Age = 22,
        Cycle = "Licence",
        Specialite = "Cybersécurité",
        Universite = "Université du Québec à Rimouski"
    },
    new Student
    {
        Nom = "Haddad",
        Prenom = "Nour",
        Age = 25,
        Cycle = "Master",
        Specialite = "Réseaux",
        Universite = "Université de Montréal"
    },
    new Student
    {
        Nom = "Kone",
        Prenom = "Fatou",
        Age = 21,
        Cycle = "Licence",
        Specialite = "Développement Web",
        Universite = "UQTR"
    },
    new Student
    {
        Nom = "Moreau",
        Prenom = "Antoine",
        Age = 26,
        Cycle = "Doctorat",
        Specialite = "Génie logiciel",
        Universite = "Université Laval"
    }
};

List<Student> otherStudetnsList = new List<Student>
{
    new Student
    {
        Nom = "Lopez",
        Prenom = "Maria",
        Age = 23,
        Cycle = "Licence",
        Specialite = "Systèmes embarqués",
        Universite = "École de technologie supérieure (ÉTS)"
    },
    new Student
    {
        Nom = "Oumarou",
        Prenom = "Salif",
        Age = 27,
        Cycle = "Master",
        Specialite = "Cloud Computing",
        Universite = "Université d’Ottawa"
    },
    new Student
    {
        Nom = "Peterson",
        Prenom = "Emily",
        Age = 21,
        Cycle = "Licence",
        Specialite = "Sciences des données",
        Universite = "McGill University"
    },
    new Student
    {
        Nom = "Rahman",
        Prenom = "Aisha",
        Age = 28,
        Cycle = "Doctorat",
        Specialite = "Cybersécurité avancée",
        Universite = "INRS"
    },
    new Student
    {
        Nom = "Gagnon",
        Prenom = "Mathieu",
        Age = 24,
        Cycle = "Master",
        Specialite = "DevOps",
        Universite = "HEC Montréal"
    }
};



Console.WriteLine("Reading the csv content before ");
CsvUtils2.CsvReader("etudiants.csv");

Console.WriteLine("######################################################");
Console.WriteLine("######################################################");

CsvUtils2.CsvWriter("etudiants.csv", studentsList);

Console.WriteLine("Reading the csv content after override ");
CsvUtils2.CsvReader("etudiants.csv");

Console.WriteLine("######################################################");
Console.WriteLine("######################################################");

CsvUtils2.CsvAppend("etudiants.csv", otherStudetnsList);

Console.WriteLine("Reading the csv content after override ");
CsvUtils2.CsvReader("etudiants.csv");