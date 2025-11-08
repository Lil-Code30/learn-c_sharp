namespace oop.classes;

class PresentationObject
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

class Text : PresentationObject
{
    public int FontSize { get; set; }
    public int FontName { get; set; }

    public void AddHyperlink(string url)
    {
        Console.WriteLine($"We added a link to ({url}).");
    }
}