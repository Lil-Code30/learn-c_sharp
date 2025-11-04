# OOP


<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/12bad32a-e88f-4972-9bce-e20331a94b67" />

---

## 💡 What is OOP?
**Object-Oriented Programming (OOP)** is a way of structuring code around **objects** — things that have **data (attributes)** and **behaviors (methods)**.

In C#, everything (almost) is an **object**.

---

## ⚙️ The 4 Core Pillars of OOP in C#

| # | Concept           | Meaning                                                     | Real-World Analogy                                                                          |
| - | ----------------- | ----------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| 1 | **Encapsulation** | Hiding internal details and exposing only what’s necessary  | A car: you can drive it without knowing how the engine works                                |
| 2 | **Abstraction**   | Simplifying complexity by showing only relevant information | A smartphone: you press a button, not caring how it processes the command                   |
| 3 | **Inheritance**   | Reusing code by creating new classes from existing ones     | A child inherits traits from their parent                                                   |
| 4 | **Polymorphism**  | Using one interface or method in many forms                 | A remote control’s "power" button works for TVs, ACs, etc. — different actions, same button |

---

# 🧩 1. **Encapsulation**

Encapsulation = **data hiding**.
We keep fields private and use **properties** or **methods** to access them safely.

### Example:

```csharp
public class BankAccount
{
    private double balance; // hidden data

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}
```

### Real-world:

* You can deposit or check your balance,
  but you can’t directly modify the internal `balance` variable.

---

# 🎯 2. **Abstraction**

Abstraction = **showing only what’s needed** and **hiding unnecessary details**.
Use **abstract classes** or **interfaces** in C#.

### Example:

```csharp
public abstract class Animal
{
    public abstract void MakeSound(); // abstract = no body
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
```

### Real-world:

* You don’t need to know *how* a dog barks, just that it **can bark**.

---

# 🧬 3. **Inheritance**

Inheritance = **reusing and extending code**.
A subclass (child) inherits from a base class (parent).

### Example:

```csharp
public class Vehicle
{
    public void Start() => Console.WriteLine("Vehicle starting...");
}

public class Car : Vehicle
{
    public void Drive() => Console.WriteLine("Car driving...");
}
```

Usage:

```csharp
Car car = new Car();
car.Start(); // from Vehicle
car.Drive(); // from Car
```

### Real-world:

* A **Car** is a type of **Vehicle** — it has all vehicle features plus some extra ones.

---

# 🔄 4. **Polymorphism**

Polymorphism = “**many forms**” — one interface, different behaviors.

There are **two types**:

### (a) Compile-time (Method Overloading)

Same method name, different parameters.

```csharp
public class MathUtils
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}
```

### (b) Runtime (Method Overriding)

Child class redefines a method from the parent using `virtual` and `override`.

```csharp
public class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a shape");
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a circle");
}
```

Usage:

```csharp
Shape s1 = new Shape();
Shape s2 = new Circle();

s1.Draw(); // "Drawing a shape"
s2.Draw(); // "Drawing a circle" → polymorphism!
```

### Real-world:

* The word “draw” means different things to an **artist** vs. an **engineer**, but the concept (action) is the same.

---

# 🧱 Bonus: **Class vs Object**

| Term       | Meaning                          | Example             |
| ---------- | -------------------------------- | ------------------- |
| **Class**  | Blueprint/template for an object | `Car`               |
| **Object** | Actual instance of that class    | `myCar = new Car()` |

### Example:

```csharp
public class Car
{
    public string Brand;
    public void Drive() => Console.WriteLine($"{Brand} is driving");
}

Car car1 = new Car();
car1.Brand = "Tesla";
car1.Drive(); // "Tesla is driving"
```

---

# 🚗 Real-World Example — *Car System*

```csharp
// Encapsulation + Abstraction
public abstract class Vehicle
{
    public string Brand { get; set; }
    public abstract void StartEngine();
}

// Inheritance
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} engine started.");
    }
}

// Polymorphism
public class ElectricCar : Car
{
    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} is powering up silently (electric mode).");
    }
}
```

Usage:

```csharp
Vehicle myCar = new Car { Brand = "Toyota" };
Vehicle myEV  = new ElectricCar { Brand = "Tesla" };

myCar.StartEngine(); // Toyota engine started.
myEV.StartEngine();  // Tesla is powering up silently (electric mode).
```

✅ Demonstrates all four OOP principles in one:

* **Encapsulation:** `Brand` and `StartEngine()` are controlled.
* **Abstraction:** `Vehicle` defines what every vehicle *must do*.
* **Inheritance:** `Car` inherits from `Vehicle`.
* **Polymorphism:** `ElectricCar` behaves differently when starting.

