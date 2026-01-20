using mse_en_application_02_01;

Point newPoint1 = new Point(4, 6);
Point newPoint2 = new Point(9, 20);

Console.WriteLine("====== Affichage des Points ========");
newPoint1.Afficher();
newPoint2.Afficher();

Console.WriteLine("======= Distance entre les deux Points ========");

double distance = newPoint1.Distance(newPoint2);

Console.WriteLine($"Distance : {distance}");

Console.WriteLine("======= Nouveau point apres deplacement ========");

newPoint1.Deplacer(2, 1);
newPoint1.Afficher();

