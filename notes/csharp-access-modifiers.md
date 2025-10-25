# C# Access Modifiers

In C#, **access modifiers** control the visibility and accessibility of types and their members (fields, methods, properties, etc.). Choosing the right modifier is essential for encapsulation, security, and maintainable APIs.

---

## 📌 Quick Reference Table

| Modifier             | Accessibility Scope                                                        |
| -------------------- | -------------------------------------------------------------------------- |
| `public`             | Any code (any assembly)                                                    |
| `private`            | Only within the **same class**                                             |
| `protected`          | Same class **or** derived classes (any assembly)                           |
| `internal`           | Any code in the **same assembly**                                          |
| `protected internal` | **`protected` OR `internal`** → derived classes **or** same assembly       |
| `private protected`  | **`protected` AND `internal`** → derived classes **in same assembly only** |

> 💡 **Default access levels**:
>
> - Class members → `private`
> - Top-level types → `internal`

---

## 🔍 Detailed Breakdown

### `public`

Accessible from **anywhere**.

```csharp
public class Car
{
    public string Model = "Tesla";
}
// Usable from any project that references this assembly.

```

✅ Use for public APIs, services, or libraries.

---

### `private`

Accessible **only within the same class**.

```csharp
public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount) => _balance += amount; // ✅ OK
}
// _balance cannot be accessed outside BankAccount.
```

✅ Use to **encapsulate internal state**.

---

### `protected`

Accessible in the **declaring class** and **derived classes** (even in other assemblies).

```csharp
public class Animal
{
    protected string Name = "Unknown";
}

public class Dog : Animal
{
    public void Rename() => Name = "Buddy"; // ✅ OK
}
```

✅ Use in base classes to expose functionality **only to subclasses**.

---

### `internal`

Accessible **anywhere within the same assembly** (`.dll` or `.exe`).

```csharp
internal class Logger
{
    internal void Log(string msg) => Console.WriteLine(msg);
}
// Accessible in same project, but not in referencing projects.
```

✅ Use for **internal helpers**, infrastructure, or testable code.

> 🔑 Tip: Expose to test projects with:
>
> ```csharp
> [assembly: InternalsVisibleTo("MyApp.Tests")]
> ```

---

### `protected internal`

**Union** of `protected` **OR** `internal`.  
Accessible if:

- Code is in the **same assembly**, **OR**
- Code is in a **derived class** (any assembly).

```csharp
public class Base
{
    protected internal string Data = "Shared";
}
```

✅ Use when you want to support **both inheritance and internal usage**.

---

### `private protected` (C# 7.2+)

**Intersection** of `private` **AND** `protected`.  
Accessible **only in derived classes within the same assembly**.

```csharp
public class Base
{
    private protected string Secret = "API_KEY";
}
// Only subclasses in the same project can access `Secret`.
```

✅ Use for **library-internal extensibility** without exposing to external consumers.

---

## 🏗️ Real-World Patterns

### 1. Encapsulation

```csharp
public class User
{
    private string _email;
    public string Email => _email; // Read-only public access
}
```

### 2. Template Method Pattern

```csharp
public abstract class Processor
{
    public void Run() { Setup(); Execute(); }
    protected abstract void Execute(); // Customizable by subclasses
}
```

### 3. Internal Testability

```csharp
// In main project
internal static class MathUtils
{
    internal static int Add(int a, int b) => a + b;
}

// In test project (with InternalsVisibleTo)
[Fact]
public void Add_ReturnsCorrectSum() => Assert.Equal(5, MathUtils.Add(2, 3));
```

---

## ✅ Best Practices

- **Start restrictive**: Prefer `private` → relax only when necessary.
- **`public` = contract**: Avoid making members `public` unless part of your API.
- **Avoid public fields**: Use properties instead (`public string Name { get; set; }`).
- **Document `protected` members**: Explain how subclasses should use/override them.
- **Prefer composition over inheritance**: Reduces reliance on `protected`.

---

## 🧭 Decision Flowchart (Simplified)

```
Need external access? ──Yes──→ public
        │
       No
        ↓
Used only in this class? ──Yes──→ private
        │
       No
        ↓
Used in derived classes? ──Yes──→ protected (or private protected if same assembly only)
        │
       No
        ↓
Used elsewhere in this project? ──Yes──→ internal
```

---

> 📝 **Note**: Access modifiers apply to **types** (classes, structs, interfaces) and **members** (methods, fields, properties, etc.), but with different rules. For example, a `public` class can contain `private` members.
