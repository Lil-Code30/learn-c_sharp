namespace gestion_de_fichier.classes;

class Person
{
    public string lastname;
    public string firstname;
    public string job;
    public int age;

    public Person(string lastname, string firstname, string job, int age)
    {
        this.lastname = lastname;
        this.firstname = firstname;
        this.job = job;
        this.age = age;
    }
}