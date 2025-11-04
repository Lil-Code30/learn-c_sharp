#🔹 1. What are properties?

In C#, **properties** are a special kind of class member that **encapsulate a field** — they control how you read or write data to it.

Instead of this (traditional way 👇):

```csharp
public class Point
{
    public int X; // field — no control or validation
}
```

You can write this:

```csharp
public class Point
{
    public int X { get; set; } // property
}
```

Now you can still do:

```csharp
Point p = new Point();
p.X = 5;              // uses the "set" accessor
Console.WriteLine(p.X); // uses the "get" accessor
```

But under the hood, `get` and `set` work like small methods:

* `get` → returns (reads) the value
* `set` → assigns (writes) the value

---

## 🔸 2. What `{ get; set; }` means

| Part  | Meaning                                            |
| ----- | -------------------------------------------------- |
| `get` | The **getter** — used to read the property’s value |
| `set` | The **setter** — used to assign a new value        |

### Example:

```csharp
public class Person
{
    public string Name { get; set; }
}
```

Usage:

```csharp
var person = new Person();
person.Name = "Ismael";         // calls set
Console.WriteLine(person.Name); // calls get
```

---

## 🔸 3. Adding logic inside `get` and `set`

You can add **custom logic** to control access or validation:

```csharp
public class Temperature
{
    private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set
        {
            if (value < -273.15)
                throw new ArgumentOutOfRangeException("Too cold!");
            celsius = value;
        }
    }
}
```

---

## 🔸 4. What about `{ get; init; }` ?

This is new since **C# 9.0** — it means the property is **immutable after initialization**.

```csharp
public class Point
{
    public int X { get; init; }
    public int Y { get; init; }
}
```

Usage:

```csharp
var p = new Point { X = 5, Y = 10 }; // ✅ OK: can set during initialization
p.X = 20; // ❌ Error: cannot modify after object creation
```

➡️ `init` makes a property **read-only** *after construction*, perfect for **immutable objects** (like records or DTOs).

---

## 🧠 Summary Table

| Accessor         | Can set value                 | Can get value | When usable              | Example                  |
| ---------------- | ----------------------------- | ------------- | ------------------------ | ------------------------ |
| `{ get; set; }`  | ✅ anytime                     | ✅ anytime     | Mutable properties       | `p.X = 5;`               |
| `{ get; }`       | ❌                             | ✅             | Read-only                | `Console.WriteLine(p.X)` |
| `{ get; init; }` | ✅ only during object creation | ✅ anytime     | Immutable after creation | `new P { X = 5 }`        |

---

### ✅ Example combining all

```csharp
public class Example
{
    public int ReadWrite { get; set; }      // mutable
    public int ReadOnly  { get; } = 10;     // constant-like
    public int InitOnly  { get; init; }     // settable once at creation
}
```

Usage:

```csharp
var e = new Example { InitOnly = 42 };
e.ReadWrite = 99; // OK
// e.InitOnly = 50; // ❌ not allowed after creation
```

