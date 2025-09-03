/*
 * 1. Print Hello and Name
   
   Write a C# Sharp program to print Hello and your name in a separate line.
   Expected Output :
 */
void  Exercise1()
{
  Console.WriteLine("Hello:");
  Console.WriteLine("Loko Ismael");
}

/*
 2. Sum of Two Numbers
    Write a C# Sharp program to print the sum of two numbers.

 */
void Exercise2(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"The sum of {a} + {b} = {sum}");
    
}

// Exercise2(3,4);

/*
 3. Divide Two Numbers
   
    Write a C# Sharp program to print the result of dividing two numbers.

 */
void Exercise3(float a, float b)
{
    float result = a / b;

    Console.WriteLine($"The result of {a} / {b} = {result}");
}

Exercise3(50, 5);