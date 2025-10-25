# public, private, and protected

In C#, `public`, `private`, and `protected` are access modifiers that control the visibility and accessibility of types (classes, structs, etc.) and their members (fields, methods, properties, etc.).

1. `public`

   - Most permissive access level.
   - Can be accessed from any code, anywhere (inside or outside the class, assembly, or inheritance hierarchy).
     Example:

   ```csharp
   public class Car
   {
       public string Model = "Tesla";

       public void Start() => Console.WriteLine("Engine started.");
   }

   class Program
   {
       static void Main()
       {
           Car car = new Car();
           Console.WriteLine(car.Model); // ✅ OK
           car.Start();                  // ✅ OK
       }
   }
   ```

   > "Use `public` for APIs, services, or anything meant to be used externally."

2. `private`

   - Most restrictive.
   - Accessible only within the same class.
   - Default access level for class members (if no modifier is specified).

   Example :

   ```csharp
   public class BankAccount
   {
    private decimal balance = 1000; // Only accessible inside BankAccount

    public void Deposit(decimal amount)
    {
        balance += amount; // ✅ OK — inside the same class
    }
   }

   class Program
   {
    static void Main()
    {
        BankAccount account = new BankAccount();
        // Console.WriteLine(account.balance); // ❌ Compile error!
    }
   }
   ```

   > "Use `private` to encapsulate internal state and prevent external interference."

3. `protected`

   - Accessible in:
     - The declaring class
     - Any derived (inherited) class
   - Not accessible from unrelated classes—even in the same file or assembly.

   Example:

   ```csharp
   public class Animal
   {
    protected string Name = "Unknown";

    protected void Speak() => Console.WriteLine($"{Name} makes a sound.");
   }

   public class Dog : Animal
   {
    public void Bark()
    {
        Name = "Buddy"; // ✅ OK — derived class
        Speak(); // ✅ OK — inherited protected method
    }
   }
   class Program
   {
    static void Main()
    {
        Dog dog = new Dog();
        // Console.WriteLine(dog.Name); // ❌ Error! Not accessible here
        dog.Bark(); // ✅ OK
    }
   }
   ```
