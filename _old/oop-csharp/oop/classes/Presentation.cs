namespace oop.classes;

class Presentation
{
    public int width { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        Console.WriteLine("Object copied to clipboard.");
    }

    public void Duplicate()
    {
        Console.WriteLine("Object was duplicated.");
    }
}

class Text : Presentation
{
    public int FontSize { get; set; }
    public int FontName { get; set; }

    public void AddHyperlink(string url)
    {
        Console.WriteLine($"We added a link to ({url}).");
    }
}

class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class DbMigrator
{
    private readonly Logger _logger;

    public DbMigrator(Logger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.Log("We are migrating the DB from PgAdmin to NeonDB.");
    }
}

class Installer
{
    private readonly Logger _logger;
    public Installer(Logger logger)
    {
        _logger = logger;
    }

    public void Install()
    {
        _logger.Log("We are installing the application.");
    }
}