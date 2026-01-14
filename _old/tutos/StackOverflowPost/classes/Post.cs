namespace StackOverFlowPost.Classes;

class Post
{
    private string _title;
    private string _description;

    private DateTime _createdAt;

    private readonly int _votes = 0;

    public Post(string title, string description)
    {
        this._title = title;
        this._description = description;
        this._createdAt = DateTime.Now;
    }

    // TODO Need to finish this class

    //Accesseurs
    public string Title
    {
        get { return _title; }
        set { this._title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { this._description = value; }
    }

    public DateTime CreatedAt
    {
        get { return _createdAt; }
        set { this._createdAt = value; }
    }
}
