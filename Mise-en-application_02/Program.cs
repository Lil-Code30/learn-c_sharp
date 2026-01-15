using Mise_en_application_02.CLasses;

Etudiant dialo = new Etudiant("Dialo", "Ismael", 19f);
Etudiants.ajouteEtudiant(dialo);

Etudiant sow = new Etudiant("Sow", "Now", 18.5f);
Etudiants.ajouteEtudiant(sow);

Etudiant traore = new Etudiant("Traoré", "Malick", 10f);
Etudiants.ajouteEtudiant(traore);

Etudiants.afficherEtudiant();

Console.WriteLine();
Console.WriteLine($"La moyenne de la classe : {Etudiants.calculMoyenne():f}");