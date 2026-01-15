using Mise_en_application_02.CLasses;

Etudiant dialo = new Etudiant("Dialo", "Ismael", 19f);
List<float> notesDialo = new List<float> { 13, 13, 15.6f, 15  };
foreach (var n in notesDialo)
{
    dialo.AjouteNote(n);
}
Etudiants.ajouteEtudiant(dialo);

Etudiant sow = new Etudiant("Sow", "Now", 18.5f);
List<float> notesSow = new List<float> { 19, 16, 15.6f, 17  };

foreach (var n in notesSow)
{
    sow.AjouteNote(n);
}
Etudiants.ajouteEtudiant(sow);

Etudiant traore = new Etudiant("Traoré", "Malick", 10f);
List<float> notesTraore = new List<float> { 20, 13, 15.6f, 18  };
foreach (float n in notesTraore)
{
    traore.AjouteNote(n);
}
Etudiants.ajouteEtudiant(traore);

Etudiants.afficherEtudiant();

Console.WriteLine();
Console.WriteLine($"La moyenne de la classe : {Etudiants.calculMoyenne():f}");
