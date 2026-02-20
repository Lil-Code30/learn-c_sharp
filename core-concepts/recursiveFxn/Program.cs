using recursiveFxn.classes;

int value = 5;
int power = 2;

Console.WriteLine("Hello World!");
Console.WriteLine(Recursive.Somme(value));
Console.WriteLine($"The factorial of {value} is  {Recursive.Factorial(value)}");
Console.WriteLine($"{value} to the power of {power} is {Recursive.Power(value, power)}");
Console.WriteLine($"The Fibonacci of {value} is {Recursive.Fibonacci(value)}");