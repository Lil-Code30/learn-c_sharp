# C# record declaration using primary constructors

The line:

```csharp
public record Transaction(decimal Amount, DateTime Date, string Notes);
```

is a **C# record declaration using primary constructors** (introduced in C# 9 and enhanced in C# 10+). It’s a concise, immutable way to model **data-centric types**—perfect for things like DTOs, domain models, or value objects such as a financial transaction.

---

### 🔍 What This Line Does (Step by Step)

#### 1. **Declares a `record` type**

- A **`record`** is a reference type designed to **encapsulate data** (not behavior).
- It comes with built-in functionality for:
  - **Value-based equality** (`==`, `.Equals()`)
  - **`ToString()`** that prints property names and values
  - **Immutability by default** (properties are `init` or `readonly`)
  - **Non-destructive mutation** via `with` expressions

#### 2. **Uses a _primary constructor_**

- The parameters in the parentheses `(decimal Amount, DateTime Date, string Notes)` define:
  - **Public `init` properties** with the same names and types
  - A **constructor** that initializes those properties

So the above single line is **equivalent to** this much longer class:

```csharp
public record Transaction
{
    public decimal Amount { get; init; }
    public DateTime Date { get; init; }
    public string Notes { get; init; }

    public Transaction(decimal Amount, DateTime Date, string Notes)
    {
        this.Amount = Amount;
        this.Date = Date;
        this.Notes = Notes;
    }

    // Compiler also generates:
    // - Equals(), GetHashCode(), ==, !=
    // - ToString()
    // - Deconstruct() method
}
```

> ✅ The compiler does all this for you—**zero boilerplate**.

---

### ✅ Key Features of This `Transaction` Record

#### ✔️ **Immutable by Default**

Once created, you can’t change the properties (they use `init` accessors):

```csharp
var tx = new Transaction(100.50m, DateTime.Now, "Coffee");
// tx.Amount = 200; // ❌ Compile error! 'init' property can't be set outside constructor
```

#### ✔️ **Value-Based Equality**

Two `Transaction` instances are equal if their **property values match**:

```csharp
var tx1 = new Transaction(100, DateTime.Today, "Lunch");
var tx2 = new Transaction(100, DateTime.Today, "Lunch");

Console.WriteLine(tx1 == tx2); // ✅ True (even though they're different objects!)
```

#### ✔️ **Nice `ToString()` Output**

```csharp
Console.WriteLine(tx1);
// Output: Transaction { Amount = 100, Date = 10/26/2025 12:00:00 AM, Notes = Lunch }
```

#### ✔️ **Non-Destructive Mutation with `with`**

Create a modified copy without changing the original:

```csharp
var txUpdated = tx1 with { Notes = "Lunch (revised)" };
// tx1 is unchanged; txUpdated is a new instance with updated Notes
```

#### ✔️ **Deconstruction Support**

You can deconstruct it into variables:

```csharp
var (amount, date, notes) = tx1;
Console.WriteLine(amount); // 100
```

---

### 🧠 When to Use `record` Like This

Use **records** for:

- **Data transfer objects (DTOs)**
- **Domain models** that represent facts (e.g., `Transaction`, `Order`, `Event`)
- **Configuration settings**
- **Messages in event-driven systems**

Avoid records for:

- Types with complex behavior/logic
- Types that need mutable state
- Performance-critical scenarios where struct (`readonly record struct`) might be better

> 💡 Tip: For better performance with small, short-lived data, consider `readonly record struct`:
>
> ```csharp
> public readonly record struct Transaction(decimal Amount, DateTime Date, string Notes);
> ```

---

### 📌 Summary

| Feature                 | Behavior                                          |
| ----------------------- | ------------------------------------------------- |
| `public record`         | Creates an immutable data type                    |
| `(decimal Amount, ...)` | Primary constructor → auto-properties with `init` |
| Equality                | Based on property values (not reference)          |
| `ToString()`            | Auto-generated readable output                    |
| `with`                  | Safe copying with changes                         |
| Thread-safe?            | ✅ Yes (immutable after construction)             |

This one-liner replaces dozens of lines of boilerplate—making C# **cleaner, safer, and more expressive** for data modeling.
