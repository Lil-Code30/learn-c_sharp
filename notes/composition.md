# Composition in C#

## 🧠 1. Core Concepts of Composition in C#

| Concept                                 | Description                                                                                                       | Example                                                                           |
| --------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| **Composition**                         | One class contains (has) an instance of another class.                                                            | `class Car { Engine engine; }`                                                    |
| **“Has-a” relationship**                | The main class delegates work to its components.                                                                  | A `Car` _has an_ `Engine`.                                                        |
| **Delegation**                          | Instead of inheriting behavior, the class uses other objects to perform tasks.                                    | `engine.Start();`                                                                 |
| **Favors composition over inheritance** | Composition allows more flexibility — classes can be combined dynamically instead of tightly coupled hierarchies. | You can swap `ElectricEngine` or `DieselEngine` without changing the `Car` class. |
| **Encapsulation**                       | Each class handles its own responsibility, improving modularity.                                                  | `Engine` handles power, `GPS` handles navigation.                                 |
| **Dependency Injection (DI)**           | A pattern that passes dependencies into a class (e.g., via the constructor).                                      | `public Car(Engine engine)`                                                       |

---

## 🚗 Scenario 1: Vehicle System with Composition

**Real-world analogy:**
Instead of a `Car` inheriting from `Vehicle`, it _has_ an `Engine` and a `Transmission`.
This makes it more flexible — the same car can have a **different engine** or **gearbox**.

---

### Code Example

```csharp
using System;

namespace CompositionDemo
{
    // Component 1: Engine
    public class Engine
    {
        public string Type { get; }

        public Engine(string type)
        {
            Type = type;
        }

        public void Start()
        {
            Console.WriteLine($"{Type} engine started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} engine stopped.");
        }
    }

    // Component 2: Transmission
    public class Transmission
    {
        public void ShiftGear(int gear)
        {
            Console.WriteLine($"Gear shifted to {gear}.");
        }
    }

    // Main class using composition
    public class Car
    {
        private Engine _engine;
        private Transmission _transmission;

        public string Model { get; }

        // Constructor Injection
        public Car(string model, Engine engine, Transmission transmission)
        {
            Model = model;
            _engine = engine;
            _transmission = transmission;
        }

        public void Drive()
        {
            _engine.Start();
            _transmission.ShiftGear(1);
            Console.WriteLine($"{Model} is driving...");
        }

        public void Stop()
        {
            _engine.Stop();
            Console.WriteLine($"{Model} has stopped.");
        }
    }

    class Program
    {
        static void Main()
        {
            var electricEngine = new Engine("Electric");
            var automaticTransmission = new Transmission();

            var car = new Car("Tesla Model 3", electricEngine, automaticTransmission);
            car.Drive();
            car.Stop();
        }
    }
}
```

---

### ✅ Key Takeaways

- `Car` **doesn’t inherit** from `Engine` or `Transmission`, it _has_ them.
- We can easily swap `Engine` types (e.g., Electric, Diesel).
- The system is **more modular and maintainable**.

---

## 💼 Scenario 2: Employee System Using Composition

**Real-world analogy:**
An `Employee` _has_ a `PaymentCalculator` or a `WorkSchedule` rather than inheriting from them.
This allows you to assign **different behaviors** dynamically.

---

### Code Example

```csharp
using System;

namespace EmployeeComposition
{
    // Behavior class for payment
    public class PaymentCalculator
    {
        public double CalculateHourlyPay(double hourlyRate, int hoursWorked)
        {
            return hourlyRate * hoursWorked;
        }

        public double CalculateMonthlyPay(double monthlySalary)
        {
            return monthlySalary;
        }
    }

    // Behavior class for schedule
    public class WorkSchedule
    {
        public void DisplaySchedule(string scheduleType)
        {
            Console.WriteLine($"Schedule type: {scheduleType}");
        }
    }

    // Main Employee class using composition
    public class Employee
    {
        private PaymentCalculator _paymentCalculator;
        private WorkSchedule _workSchedule;

        public string Name { get; set; }
        public string Type { get; set; }

        public Employee(string name, string type, PaymentCalculator calculator, WorkSchedule schedule)
        {
            Name = name;
            Type = type;
            _paymentCalculator = calculator;
            _workSchedule = schedule;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Type} Employee");
            _workSchedule.DisplaySchedule(Type == "FullTime" ? "9-5 Mon-Fri" : "Flexible");
        }

        public void DisplaySalary()
        {
            double salary = Type == "FullTime"
                ? _paymentCalculator.CalculateMonthlyPay(4000)
                : _paymentCalculator.CalculateHourlyPay(25, 80);

            Console.WriteLine($"Salary: ${salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            var calculator = new PaymentCalculator();
            var schedule = new WorkSchedule();

            var fullTimeEmp = new Employee("Alice", "FullTime", calculator, schedule);
            var partTimeEmp = new Employee("Bob", "PartTime", calculator, schedule);

            fullTimeEmp.DisplayInfo();
            fullTimeEmp.DisplaySalary();

            partTimeEmp.DisplayInfo();
            partTimeEmp.DisplaySalary();
        }
    }
}
```

---

### ✅ Key Takeaways

- `Employee` **has** a `PaymentCalculator` and `WorkSchedule`.
- Each component handles a **specific concern**.
- Composition allows **reusability** (same `PaymentCalculator` can be shared among many employees).
- The system is easier to modify — no fragile inheritance chains.

---

## 🧩 Inheritance vs Composition

| Feature      | Inheritance                               | Composition                                 |
| ------------ | ----------------------------------------- | ------------------------------------------- |
| Relationship | “Is-a”                                    | “Has-a”                                     |
| Example      | `Car : Vehicle`                           | `Car has Engine`                            |
| Coupling     | Tight                                     | Loose                                       |
| Reuse        | Inherits behavior                         | Delegates behavior                          |
| Flexibility  | Hard to change                            | Very flexible                               |
| Polymorphism | Yes                                       | Achievable via interfaces                   |
| Example Use  | Common hierarchy (Animal → Dog → Bulldog) | Modular systems (Car has Engine, GPS, etc.) |

---

## 🚀 In Summary

- **Use inheritance** when you have a clear _“is-a”_ hierarchy.
- **Use composition** when you need flexibility and modular design.
- In real projects, developers often **mix both** (composition inside base classes).

---
