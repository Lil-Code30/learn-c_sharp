

class Program
{
    static void Main()
  {
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

// Exercise3(50, 5);

/*
 *
 * 4. Specified Operations Results
   
   Write a C# Sharp program to print the results of the specified operations.
   Test data:
   
   -1 + 4 * 6
   ( 35+ 5 ) % 7
   14 + -4 * 6 / 11
   2 + 15 / 6 * 1 - 7 % 2
   Expected Output:
   23
   5
   12
   3
 */
void Exercise4()
{
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine(( 35+ 5 ) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
}

// Exercise4();

/*
 *
 * 5. Swap Two Numbers
   
   Write a C# Sharp program to swap two numbers.
   Test Data:
   Input the First Number : 5
   Input the Second Number : 6
   Expected Output:
   After Swapping :
   First Number : 6
   Second Number : 5
 */
void Exercise5()
{
    Console.Write("Input the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
     // int temp = num1;
     // num1 = num2;
     // num2 = temp;
     

    (num1, num2) = (num2, num1);
    Console.WriteLine("After Swapping :");
    Console.WriteLine($"First number: {num1}");
    Console.WriteLine($"Second number: {num2}");
}

// Exercise5();

/*
 * 6. Multiply Three Numbers
   
   Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
   Test Data:
   Input the first number to multiply: 2
   Input the second number to multiply: 3
   Input the third number to multiply: 6
   Expected Output:
   2 x 3 x 6 = 36
 */

void Exercise6()
{
    Console.Write("Input the first number to multiply: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input the second number to multiply: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input the third number to multiply: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    int product = num1 * num2 * num3;
    
    Console.WriteLine($"{num1} x {num2} x {num3} = {product}");
}

// Exercise6();

/*
 * 7. Arithmetic Operations
   
   Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
   Test Data:
   Input the first number: 25
   Input the second number: 4
   Expected Output:
   25 + 4 = 29
   25 - 4 = 21
   25 x 4 = 100
   25 / 4 = 6
   25 mod 4 = 1
 */

void Exercise7()
{
    Console.Write("Input the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    // Operations
    int sum =  num1 + num2;
    int diff = num1 - num2;
    int product = num1 *  num2;
    int division = num1 / num2;
    int mod = num1 % num2;
    
    Console.WriteLine($"{num1} + {num2} = {sum}");
    Console.WriteLine($"{num1} - {num2} = {diff}");
    Console.WriteLine($"{num1} x {num2} = {product}");
    Console.WriteLine($"{num1} / {num2} = {division}");
    Console.WriteLine($"{num1} mod {num2} = {mod}");
}

// Exercise7();

/*
 * 8. Multiplication Table
   
   Write a C# Sharp program that prints the multiplication table of a number as input.
   Test Data:
   Enter the number: 5
   Expected Output:
   5 * 0 = 0
   5 * 1 = 5
   5 * 2 = 10
   5 * 3 = 15
   ....
   5 * 10 = 50
 */

void Exercise8()
{
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"The Multiplication Table of {num} from 0 to 10 :");

    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
}

// Exercise8();

/*
 * 9. Average of Four Numbers
   
   Write a C# Sharp program that takes four numbers as input to calculate and print the average.
   Test Data:
   Enter the First number: 10
   Enter the Second number: 15
   Enter the third number: 20
   Enter the four number: 30
   
   Expected Output:
   The average of 10 , 15 , 20 , 30 is: 18
 */

void Exercise9()
{
    Console.Write("Enter the First number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter the Second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter the third number: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter the four number: ");
    int num4 = Convert.ToInt32(Console.ReadLine());
    
    int average = (num1 + num2 + num3 + num4) / 4;
    
    Console.WriteLine($"The average of {num1} , {num2} , {num3} , {num4} is: {average}");
}

// Exercise9();

/*
 * 10. Specified Formula with Three Numbers
   
   Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
   Test Data:
   Enter first number - 5
   Enter second number - 6
   Enter third number - 7
   
   Expected Output:
   Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 */

void Exercise10()
{
    Console.WriteLine("A C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.");
    
    Console.Write("Enter first number - ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter second number - ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter third number - ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    int op1 = (num1 + num2) * num3;
    int op2 = num1 * num2 + num2 * num3;
    
    Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3}, (x+y).z is {op1} and x.y + y.z is {op2}");
}

// Exercise10();

/*
 * 11. Print Age Message
   
   Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
   Test Data:
   Enter your age - 25
   Expected Output:
   You look older than 25
 */
void Exercise11()
{
    Console.Write("Enter your age - ");
    int age = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"You look older than {age}");
}

// Exercise11();

/*
 * 12. Repeat Number in Rows
   
   Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
   Test Data:
   Enter a digit: 25
   Expected Output:
   25 25 25 25
   25252525
   25 25 25 25
   25252525
 */
void Exercise12()
{
    Console.Write("Enter a digit: ");
    int digit = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= 2; i++)
    {
        Console.WriteLine("{0} {0} {0} {0}", digit);
        // Console.WriteLine($"{digit} {digit} {digit} {digit}");
        Console.WriteLine("{0}{0}{0}{0}", digit);
    }
}
// void test()
// {
//     int num; // Variable to store the digit entered by the user
//
//     // Prompting the user to enter a digit
//     Console.WriteLine("Enter a digit: ");
//     // Reading the digit entered by the user and converting it to an integer
//     num = Convert.ToInt32(Console.ReadLine());
//
//     // Part A: "num num num num" using Write
//     Console.Write(num);
//     Console.Write(" ");
//     Console.Write(num);
//     Console.Write(" ");
//     Console.Write(num);
//     Console.Write(" ");
//     Console.Write(num);
//     Console.WriteLine();
//
//     // Part B: "numnumnumnum" using Write
//     Console.Write(num);
//     Console.Write(num);
//     Console.Write(num);
//     Console.WriteLine(num);
//     Console.WriteLine();
//
//     // Part C: "num num num num" using {0}
//     Console.WriteLine("{0} {0} {0} {0} ", num);
//
//     // Part D: "numnumnumnum" using {0}
//     Console.WriteLine("{0}{0}{0}{0}", num);
// }
// test();

// Exercise12();

/*
 * 13. Rectangle Pattern with Number
   
   Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
   Test Data:
   Enter a number: 5
   Expected Output:
   555
   5 5
   5 5
   5 5
   555
 */
void Exercise13()
{
    Console.Write(" Enter a number: ");
    int num =  Convert.ToInt32(Console.ReadLine());
    
    // row
    for (int i = 1; i <= 5; i++)
    {   
        // columns
        for (int j = 1; j<= 3; j++)
        {
            
            if (j == 1 || j == 3 || i == 1 || i == 5)
            {
                Console.Write(num); 
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

// Exercise13(); 
    }
}