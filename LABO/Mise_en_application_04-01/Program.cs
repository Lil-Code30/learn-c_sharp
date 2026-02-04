using Mise_en_application_04_01;


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

CsvUtils.CsvWriter("personnes.csv", students);
Console.WriteLine("Fichier CSV écrit avec succès !");

CsvUtils.CsvReader("personnes.csv");