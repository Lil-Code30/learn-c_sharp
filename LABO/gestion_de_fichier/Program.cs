using System.IO; // include the System.IO namespace
string directory = "/Users/ismaelloko/Downloads/_workstation/Workstation/C#/Learning/learn-c_sharp/LABO/gestion_de_fichier/repo";
string filename = "myfile.txt";
string filePath = directory + "/" + filename;

// Directory.CreateDirectory(directory);
//
// Console.WriteLine($"Current Directory : {Directory.GetCurrentDirectory()}");

// reading the file contain
Console.WriteLine("=== Reading the file contain ===");
if (File.Exists(filePath))
{
    string contents = File.ReadAllText(filePath);
    Console.WriteLine(contents);
}
else
{
    Console.WriteLine("File not found");
}

string filename2 = "myFile_02.txt"; 
string filePath2 = directory + "/" + filename2;
string textToWrite = "Hello World!";

Console.WriteLine("Writing in a file....");

File.WriteAllText(filePath2, textToWrite);



