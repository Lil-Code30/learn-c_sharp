namespace oop.classes;

class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine($"Hi {to}, I am {Name}");
    }


    public static  Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;

        return person;
    }
}