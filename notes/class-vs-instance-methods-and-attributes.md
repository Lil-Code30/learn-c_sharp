# 🧩 In Object-Oriented Programming (C#)

A **class** is like a **blueprint** that defines **attributes (data)** and **methods (actions)** for an object.

---

### ⚙️ 1. Class Attributes and Methods

These belong to the **class itself**, not to a specific object instance.
They are declared with the `static` keyword.

#### 🔹 Example:

```csharp
public class Car
{
    // Class attribute
    public static int numberOfWheels = 4;

    // Class method
    public static void ShowType()
    {
        Console.WriteLine("All cars have wheels.");
    }
}
```

#### 🔹 Usage:

```csharp
Console.WriteLine(Car.numberOfWheels); // Access without creating an object
Car.ShowType(); // Works without an instance
```

➡️ **Class members** are shared across all objects of that class.

---

### 🚗 2. Instance Attributes and Methods (Object Attributes & Methods)

These belong to each **individual object** created from the class.
They are declared **without `static`**.

#### 🔹 Example:

```csharp
public class Car
{
    // Instance attributes
    public string color;
    public string brand;

    // Instance method
    public void Drive()
    {
        Console.WriteLine($"{brand} car in {color} is driving.");
    }
}
```

#### 🔹 Usage:

```csharp
Car myCar = new Car();
myCar.color = "red";
myCar.brand = "Tesla";
myCar.Drive(); // Output: Tesla car in red is driving.

Car anotherCar = new Car();
anotherCar.color = "blue";
anotherCar.brand = "BMW";
anotherCar.Drive(); // Output: BMW car in blue is driving.
```

➡️ Each **object** has its **own copy** of instance attributes.

---

### 🧠 Summary Table

| Type                   | Keyword  | Belongs To | Accessed Using       | Shared? | Example                            |
| ---------------------- | -------- | ---------- | -------------------- | ------- | ---------------------------------- |
| **Class Attribute**    | `static` | Class      | `Car.numberOfWheels` | ✅ Yes  | `public static int numberOfWheels` |
| **Instance Attribute** | _(none)_ | Object     | `myCar.color`        | ❌ No   | `public string color`              |
| **Class Method**       | `static` | Class      | `Car.ShowType()`     | ✅ Yes  | `public static void ShowType()`    |
| **Instance Method**    | _(none)_ | Object     | `myCar.Drive()`      | ❌ No   | `public void Drive()`              |

---

This is a **classic use case** for a **class (static) attribute** in C#.

## 🚗 Goal

You want to **count how many cars (objects)** have been created from your `Car` class.

---

## ✅ Solution — Use a `static` counter field

### Example:

```csharp
public class Car
{
    // Static attribute — shared by all cars
    public static int numberOfCars = 0;

    // Instance attributes — unique for each car
    public string Brand;
    public string Color;

    // Constructor — runs every time you create a new car
    public Car(string brand, string color)
    {
        Brand = brand;
        Color = color;

        // Increment static counter
        numberOfCars++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Brand} ({Color}) created.");
    }
}
```

---

### 🧩 Usage:

```csharp
class Program
{
    static void Main()
    {
        Car car1 = new Car("Tesla", "Red");
        car1.DisplayInfo();

        Car car2 = new Car("BMW", "Blue");
        car2.DisplayInfo();

        Car car3 = new Car("Toyota", "Black");
        car3.DisplayInfo();

        // Show total number of cars created
        Console.WriteLine($"Total cars created: {Car.numberOfCars}");
    }
}
```

### 🖥️ Output:

```
Tesla (Red) created.
BMW (Blue) created.
Toyota (Black) created.
Total cars created: 3
```

---

## 🔍 Explanation

| Concept                   | Description                                                            |
| ------------------------- | ---------------------------------------------------------------------- |
| `static int numberOfCars` | Shared by all `Car` objects; one copy only.                            |
| Constructor               | Automatically increments the counter each time a new `Car` is created. |
| `Car.numberOfCars`        | Accessed via the class (not through an instance).                      |

---

## 🧠 Real-World Analogy

Think of a **factory** that produces cars:

- Each time a new car leaves the line → the factory counter increments.
- The counter belongs to the **factory (class)**, not to any individual **car (object)**.

---
