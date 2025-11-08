# Upcasting and Downcasting

---

## 🧠 1. What Is **Upcasting**?

### ➤ Definition

**Upcasting** = converting a **child (derived class)** object to a **parent (base class)** reference.

✅ It’s **safe** and **implicit** — no explicit cast required.

---

### Example

```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Animal eats");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Dog barks");
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Animal animal = dog; // 🟢 Upcasting

        animal.Eat();  // ✅ Works (method in base class)
        // animal.Bark(); ❌ Error — base class doesn’t know about Bark()
    }
}
```

### 🔍 What’s happening

- `Dog` inherits from `Animal`, so a `Dog` _is an_ `Animal`.
- The compiler only allows access to **members of the base class** (`Eat()`).
- The **object in memory** is still a `Dog`, but you’re looking at it through an `Animal` reference.

---

### 🧩 Real-world analogy

Imagine a **Dog** 🐶 is registered as an **Animal** in a pet database.
You can still feed it (`Eat()`), but you can’t tell it to bark (`Bark()`), because the database only knows it as a general `Animal`.

---

## 🧠 2. What Is **Downcasting**?

### ➤ Definition

**Downcasting** = converting a **base class** reference back into a **derived class** reference.

⚠️ It’s **explicit** and **risky** — you must manually tell the compiler to cast,
and it can fail at runtime if the object is not actually that type.

---

### Example

```csharp
class Animal
{
    public void Eat() => Console.WriteLine("Animal eats");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Dog barks");
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog(); // 🟢 Upcasting (safe)
        Dog dog = (Dog)animal;     // 🔽 Downcasting (explicit)

        dog.Bark();  // ✅ Works now
    }
}
```

✅ Works fine because the `animal` object **was originally a `Dog`**.

---

### ⚠️ But if it’s not a `Dog`…

```csharp
Animal animal = new Animal();
Dog dog = (Dog)animal; // ❌ InvalidCastException at runtime
```

💥 You’ll get a **runtime error** because the object in memory is a pure `Animal`, not a `Dog`.

---

### ✅ Safe Downcasting with `is` and `as`

#### Using `is`

```csharp
if (animal is Dog realDog)
{
    realDog.Bark();
}
```

#### Using `as`

```csharp
Dog dog = animal as Dog;
if (dog != null)
{
    dog.Bark();
}
```

Both help you **avoid runtime exceptions**.

---

## ⚙️ 3. Visual Representation

```
    ┌────────────┐
    │   Animal   │
    └────────────┘
          ▲
          │ (Upcasting)
          │
    ┌────────────┐
    │    Dog     │
    └────────────┘
          │
          │ (Downcasting)
          ▼
    (Back to Dog)
```

---

## 💼 4. Real-World Scenario

Let’s apply this to a real case — a **Payment System**.

---

### Code Example

```csharp
using System;

abstract class Payment
{
    public abstract void Process();
}

class CreditCardPayment : Payment
{
    public override void Process()
    {
        Console.WriteLine("Processing credit card payment...");
    }

    public void ValidateCard()
    {
        Console.WriteLine("Validating credit card details...");
    }
}

class Program
{
    static void Main()
    {
        // Upcasting
        Payment payment = new CreditCardPayment(); // ✅ implicit upcast
        payment.Process(); // Works

        // payment.ValidateCard(); ❌ Not visible (base class doesn’t have it)

        // Downcasting
        CreditCardPayment cardPayment = (CreditCardPayment)payment;
        cardPayment.ValidateCard(); // ✅ Works now

        // Safe Downcasting Example
        if (payment is CreditCardPayment p)
        {
            p.ValidateCard();
        }
    }
}
```

---

### 🧩 Why it matters

- **Upcasting** lets you treat many objects (CreditCardPayment, PayPalPayment, etc.) as `Payment`.
  → Great for **polymorphism** and clean API design.
- **Downcasting** is useful when you need access to **specific behavior** of a subclass,
  but use it **carefully**.

---

## 🧱 5. Summary Table

| Concept         | Direction                            | Syntax              | Safe?          | Example           | Use Case                |
| --------------- | ------------------------------------ | ------------------- | -------------- | ----------------- | ----------------------- |
| **Upcasting**   | Derived → Base                       | `Animal a = dog;`   | ✅ Always safe | `Dog → Animal`    | Polymorphism            |
| **Downcasting** | Base → Derived                       | `Dog d = (Dog)a;`   | ⚠️ Can fail    | `Animal → Dog`    | Access subclass members |
| **Using `is`**  | Check type before casting            | `if (a is Dog d)`   | ✅ Safe        | Type checking     |                         |
| **Using `as`**  | Try casting, returns `null` if fails | `Dog d = a as Dog;` | ✅ Safe        | Conditional logic |                         |

---

## 🧠 Quick Tip

When you find yourself needing **a lot of downcasting**, it might be a sign of **poor class design**.
Prefer **polymorphism** (using `virtual` or `abstract` methods) so you don’t have to cast at all.

---
