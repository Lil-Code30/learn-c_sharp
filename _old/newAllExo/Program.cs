using newAllExo.ex;

class Programm
{
    public static void Main()
    {
        string test1 = "my   ID";
        string test2 = "my\0ID";
        string test3 = "à-ḃç";
        string test4 = "MyΟβιεγτFinder";

        Console.WriteLine(SqueakyClean.Clean(test1));
        Console.WriteLine(SqueakyClean.Clean(test2));
        Console.WriteLine(SqueakyClean.Clean(test3));
        Console.WriteLine( SqueakyClean.Clean(test4));
       
    }
}