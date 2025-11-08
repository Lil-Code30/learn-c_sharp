# Inheritance in C#

## 🧠 1. Core Concepts of Inheritance in C#

| Concept                                       | Description                                                                                               | Example                                                 |
| --------------------------------------------- | --------------------------------------------------------------------------------------------------------- | ------------------------------------------------------- |
| **Base class (Parent)**                       | The class whose members are inherited.                                                                    | `class Vehicle { }`                                     |
| **Derived class (Child)**                     | The class that inherits members of another class.                                                         | `class Car : Vehicle { }`                               |
| **Single inheritance**                        | A class inherits from only one base class (C# does not allow multiple inheritance for classes).           | `class ElectricCar : Car { }`                           |
| **Access modifiers**                          | Determine what members are visible to derived classes. `protected` allows access only in derived classes. | `protected string brand;`                               |
| **`base` keyword**                            | Used to call the base class constructor or access base class members.                                     | `base.Brand = "Toyota";`                                |
| **Method overriding (`virtual`, `override`)** | Used to redefine base class methods in a derived class.                                                   | `public override void Drive() { ... }`                  |
| **`sealed` keyword**                          | Prevents a class from being inherited or a method from being overridden.                                  | `sealed class FinalCar { }`                             |
| **`abstract` class**                          | A class that cannot be instantiated directly — it serves as a template.                                   | `abstract class Shape { public abstract void Draw(); }` |
| **`interface` vs inheritance**                | C# supports multiple **interfaces**, which are like contracts.                                            | `class Car : Vehicle, IStartable { }`                   |
| **Constructor chaining**                      | Derived class constructors call the base constructor using `base(...)`.                                   | `public Car(string brand) : base(brand) { }`            |
| **Polymorphism**                              | Ability to use base class references for derived class objects.                                           | `Vehicle v = new Car(); v.Drive();`                     |

---

## 🚗 Scenario 1: Vehicle Inheritance Hierarchy

**Real-world analogy:**
You have a **Vehicle** base class, and specific vehicles like **Car** and **Truck** inherit from it.

### Code Example

```csharp
using System;

namespace InheritanceDemo
{
    // Base class
    public class Vehicle
    {
        protected string Brand;

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{Brand} engine stopped.");
        }
    }

    // Derived class
    public class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string brand, int doors) : base(brand)
        {
            Doors = doors;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} car with {Doors} doors started smoothly.");
        }
    }

    // Derived class
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(string brand, int capacity) : base(brand)
        {
            LoadCapacity = capacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} truck with {LoadCapacity}kg load capacity started.");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle car = new Car("Toyota", 4);
            Vehicle truck = new Truck("Volvo", 5000);

            car.StartEngine();
            truck.StartEngine();

            car.StopEngine();
            truck.StopEngine();
        }
    }
}
```

### ✅ Key Concepts Shown:

- Base/Derived class
- `base()` constructor call
- `virtual` and `override`
- Polymorphism (`Vehicle car = new Car(...)`)

---

## 💼 Scenario 2: Employee Management System

**Real-world analogy:**
You have different types of employees — **FullTimeEmployee** and **PartTimeEmployee** — but both share common behaviors like `CalculateSalary()` and `DisplayInfo()`.

### Code Example

```csharp
using System;

namespace EmployeeSystem
{
    // Abstract base class
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }

        // Abstract method - must be implemented in derived classes
        public abstract double CalculateSalary();

        // Virtual method - can be overridden
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name} (ID: {Id})");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, int id, double salary)
            : base(name, id)
        {
            MonthlySalary = salary;
        }

        public override double CalculateSalary() => MonthlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, int id, double rate, int hours)
            : base(name, id)
        {
            HourlyRate = rate;
            HoursWorked = hours;
        }

        public override double CalculateSalary() => HourlyRate * HoursWorked;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Type: Part-Time");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new FullTimeEmployee("Alice", 101, 4000);
            Employee emp2 = new PartTimeEmployee("Bob", 102, 25, 80);

            emp1.DisplayInfo();
            Console.WriteLine($"Salary: {emp1.CalculateSalary()}");

            emp2.DisplayInfo();
            Console.WriteLine($"Salary: {emp2.CalculateSalary()}");
        }
    }
}
```

### ✅ Key Concepts Shown:

- **Abstract class** and **abstract methods**
- **Method overriding**
- **Polymorphism** via `Employee emp = new FullTimeEmployee(...)`
- **Constructor chaining**

---

## 🧩 Summary of What You Learned

| Concept                | Description                                                 |
| ---------------------- | ----------------------------------------------------------- |
| `virtual` / `override` | Customize behavior in derived classes                       |
| `base`                 | Access base class constructor or members                    |
| `protected`            | Make members visible only to derived classes                |
| `abstract`             | Define a blueprint class                                    |
| `sealed`               | Prevent further inheritance                                 |
| Polymorphism           | Treat different subclasses as the same base type            |
| Constructor chaining   | Share initialization logic between base and derived classes |

---
