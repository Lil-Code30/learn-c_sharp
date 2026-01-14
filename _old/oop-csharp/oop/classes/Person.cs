namespace oop.classes;

class Person
{
    public string Name;

    public DateTime Birthdate { get; set; }

    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }
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