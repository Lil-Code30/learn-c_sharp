using mise_en_application_02_ex03.classes;

Duree duree01 = new Duree(20, 30, 30);
Duree duree02 = new Duree(10, 10, 30);
Duree duree03 = new Duree(00, 30, 30);

Duree addition = duree01 + duree02;
Duree soustraction = duree01 - duree02;

Console.WriteLine("================ surcharges des opérateurs : Arithmétiques =================");

Console.WriteLine("Addition des Duree : ");
addition.Afficher();
Console.WriteLine("+++++++++++++++++++++++++++++++++");
Console.WriteLine("Soustraction des Duree : ");
soustraction.Afficher();

Console.WriteLine("=============================================================================");

Console.WriteLine("================ surcharges des opérateurs : Comparaison =================");
Console.WriteLine($"- Duree 01 equal to Duree 02 ? : {duree01 == duree02}");
Console.WriteLine($"- Duree 01 not equal to Duree 02 ? : {duree01 != duree02}");
Console.WriteLine($"- Duree 01 greater than Duree 02 ? : {duree01 > duree02}");
Console.WriteLine($"- Duree 01 less than to Duree 02 ? : {duree01 < duree02}");
Console.WriteLine($"- Duree 02 greater than Duree 01 ? : {duree02 > duree01}");
Console.WriteLine($"- Duree 02 less than Duree 01 ? : {duree02 < duree01}");
Console.WriteLine($"- Duree 01 greater than or equal to Duree 02 ? : {duree01 >= duree02}");
Console.WriteLine($"- Duree 01 less than or equal to Duree 02 ? : {duree01 <= duree02}");
Console.WriteLine($"- Duree 02 greater than or equal to Duree 01 ? : {duree02 >= duree01}");
Console.WriteLine($"- Duree 02 less than or equal to Duree 01 ? : {duree02 <= duree01}");
Console.WriteLine("=============================================================================");
Console.WriteLine();
Console.WriteLine("================ Convert Duree to Seconds =================");
Console.WriteLine($"Convert Duree 01 to Seconds : {duree01.ToSecond()} Seconds");
Console.WriteLine($"Convert Duree 03 to Seconds : {duree03.ToSecond()} Seconds");