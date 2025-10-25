namespace Inheritance;

// WorkItem implicitly inherits from the Object class
public class WorkItem
{
    // Static field currentID store the Job ID of the last WorkItem that has been created
    private static int currentID;
    
    // Properties
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }
    
    // Default constructor. If a derived class does not invoke a base-class constructor explicitly
    // the default constructor is called implicitly
    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description";
        jobLength = new TimeSpan();
    }
    
    // Instance constructor that has three parameters.
    public WorkItem(string title, string desc, TimeSpan jobLen)
    {
        ID = GetNextID();
        Title = title;
        Description = desc;
        jobLength = jobLen;
    }
    
    // Static constructor to initialize the static member, currentID. This
    // constructor is called one time, automatically, before any instance
    // of WorkItem or ChangeRequest is created, or currentID is referenced.
    static WorkItem() => currentID = 0;
    
    // currentID is a static field. It is incremented each time a new
    // instance of WorkItem is created.
    protected int GetNextID() => ++currentID;
    
   // Method Update enables you to update the title and job Length of an existing WorkItem object
   public void Update(string title, TimeSpan jobLen)
   {
       this.Title = title;
       this.jobLength = jobLen;
   }
   
   // Virtual method override of the ToString method that is inherited from System.Object
   public override string ToString() => $"{this.ID} - {this.Title}";
}

// ChangeRequest drives from WorkItem and adds a property (originalItemID) and two constructors
public class ChangeRequest : WorkItem
{
    protected int originalItemID { get; set; }
    
    
}
class Programm
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}