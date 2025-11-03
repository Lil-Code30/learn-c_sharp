
## 🧩 **Main Idea**

| Keyword    | `const`                                    | `readonly`                                        |
| ---------- | ------------------------------------------ | ------------------------------------------------- |
| Meaning    | Constant value known **at compile-time**   | Value assigned **at runtime (once only)**         |
| When set   | Must be assigned **at declaration**        | Can be assigned **in declaration or constructor** |
| Modifiable | ❌ Never (fixed at compile time)            | ✅ Once (at runtime before constructor ends)       |
| Storage    | Static by default (same for all instances) | Per instance (unless declared `static readonly`)  |
| Evaluation | Compile-time constant                      | Runtime constant                                  |

---

## 🧠 **In simple words**

* `const` → **fixed forever**; baked into the compiled code.
* `readonly` → **set once**, but can depend on runtime logic (e.g., constructor).

---

### ✅ **Example with `const`**

```csharp
public class MathConstants
{
    public const double Pi = 3.14159; // Must be known at compile time
}
```

Usage:

```csharp
Console.WriteLine(MathConstants.Pi); // 3.14159
```

⛔ You cannot do this:

```csharp
public const double RandomValue = new Random().NextDouble(); // ❌ Error
```

Because the value isn’t known at compile time.

---

### ✅ **Example with `readonly`**

```csharp
public class ServerConfig
{
    public readonly int Port;

    public ServerConfig(int port)
    {
        Port = port; // OK: assigned at runtime
    }
}
```

Usage:

```csharp
var config = new ServerConfig(8080);
Console.WriteLine(config.Port); // 8080
```

⛔ You cannot change it later:

```csharp
config.Port = 9000; // ❌ Error: readonly field
```

---

## ⚙️ **Static + readonly**

You can combine `static` and `readonly` for **runtime constants shared by all instances**:

```csharp
public static readonly string AppVersion = 
    $"v{DateTime.Now.Year}.1"; // OK at runtime
```

You **can’t** do that with `const`.

---

### 🧾 Summary Chart

| Feature                   | `const`                      | `readonly`                          |
| ------------------------- | ---------------------------- | ----------------------------------- |
| Compile-time value        | ✅                            | ❌                                   |
| Runtime assignment        | ❌                            | ✅                                   |
| Can assign in constructor | ❌                            | ✅                                   |
| Default is static         | ✅                            | ❌                                   |
| Used for                  | Fixed values (e.g., Math.PI) | Configurable but immutable fields   |
| Example                   | `const int Max = 100;`       | `readonly int id = Guid.NewGuid();` |

---
