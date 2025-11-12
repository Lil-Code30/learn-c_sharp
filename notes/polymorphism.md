# Polymorphism

---

## 🧠 1. Definition of Polymorphism

**Polymorphism** means **“many forms.”**

In C#, it allows **one interface (or base class)** to be used for **different types of objects**.
Each object can have its own specific **implementation of a shared behavior**.

---

### In simple words:

> The same method name can behave differently depending on the object that calls it.

---

### Example

```csharp
Animal a = new Dog();
Animal b = new Cat();

a.Speak(); // "Woof!"
b.Speak(); // "Meow!"
```

Both are `Animal`, but they act differently — **that’s polymorphism**.

---

## 🧩 2. Types of Polymorphism in C#

| Type                      | Description                                                                  | Example                         |
| ------------------------- | ---------------------------------------------------------------------------- | ------------------------------- |
| **Compile-time (Static)** | Method overloading or operator overloading — decided at **compile time**.    | `Print(int)` vs `Print(string)` |
| **Runtime (Dynamic)**     | Method overriding — decided at **runtime**, based on the actual object type. | `Dog.Speak()` vs `Cat.Speak()`  |

---

## ⚙️ 3. Compile-Time Polymorphism (Method Overloading)

### ➤ Example

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(3, 5));       // 8
        Console.WriteLine(calc.Add(2.5, 4.3));   // 6.8
        Console.WriteLine(calc.Add(1, 2, 3));    // 6
    }
}
```

✅ The compiler automatically decides which `Add()` method to call based on the arguments’ types and number.

---

## ⚙️ 4. Runtime Polymorphism (Method Overriding)

This is the **true polymorphism** used with inheritance and `virtual` / `override`.

---

### Example

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();

        a1.Speak(); // Dog says: Woof!
        a2.Speak(); // Cat says: Meow!
    }
}
```

### 🔍 What’s happening:

- The **reference type** is `Animal`.
- The **actual object** is `Dog` or `Cat`.
- The correct `Speak()` method runs based on the **actual type**, not the reference type.

This is **runtime (dynamic) polymorphism**.

---

## 🔁 5. Real-World Example: Payment System

### Scenario:

Your app supports multiple payment methods — each processes payments differently,
but they share the same base structure.

---

```csharp
using System;

abstract class Payment
{
    public abstract void ProcessPayment(double amount);
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ${amount} with Credit Card...");
    }
}

class PayPalPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ${amount} through PayPal...");
    }
}

class CryptoPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ${amount} in Bitcoin...");
    }
}

class Program
{
    static void Main()
    {
        Payment[] payments =
        {
            new CreditCardPayment(),
            new PayPalPayment(),
            new CryptoPayment()
        };

        foreach (var payment in payments)
        {
            payment.ProcessPayment(100);
        }
    }
}
```

### 💡 Output:

```
Processing $100 with Credit Card...
Processing $100 through PayPal...
Processing $100 in Bitcoin...
```

✅ All objects share the same interface (`Payment`), but each behaves differently.

---

## 🎮 6. Game Example (AcadXP Style)

Imagine your `Character` class has a `PerformAction()` method.
Each subclass (`Player`, `Enemy`, `NPC`) performs it differently.

---

```csharp
using System;

class Character
{
    public virtual void PerformAction()
    {
        Console.WriteLine("Character performs a generic action");
    }
}

class Player : Character
{
    public override void PerformAction()
    {
        Console.WriteLine("Player attacks with sword!");
    }
}

class Enemy : Character
{
    public override void PerformAction()
    {
        Console.WriteLine("Enemy casts a fireball!");
    }
}

class NPC : Character
{
    public override void PerformAction()
    {
        Console.WriteLine("NPC gives a quest!");
    }
}

class Game
{
    static void Main()
    {
        Character[] characters =
        {
            new Player(),
            new Enemy(),
            new NPC()
        };

        foreach (var c in characters)
        {
            c.PerformAction(); // Polymorphism in action 🎮
        }
    }
}
```

### 💥 Output:

```
Player attacks with sword!
Enemy casts a fireball!
NPC gives a quest!
```

Each object implements the same method name but with **different behavior**.

---

## 🧩 7. Summary Table

| Type                          | Mechanism          | Keyword                | Binding Time | Example                                |
| ----------------------------- | ------------------ | ---------------------- | ------------ | -------------------------------------- |
| **Compile-time polymorphism** | Method overloading | None                   | Compile-time | `Add(int,int)` vs `Add(double,double)` |
| **Runtime polymorphism**      | Method overriding  | `virtual` / `override` | Runtime      | `Animal.Speak()` → `Dog.Speak()`       |

---

## 🧠 8. Key Points to Remember

- `virtual` → marks a method as overridable.
- `override` → provides a new implementation in the derived class.
- `abstract` → forces derived classes to implement it.
- `sealed` → prevents further overriding.
- Polymorphism makes code **flexible**, **extendable**, and **easier to maintain**.

---
