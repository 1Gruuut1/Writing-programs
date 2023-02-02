// Футкционал Console.WriteLine()

// int number1 = 5;
// int number2 = 8;

// Console.WriteLine("My namber are " + number1 + " and " + number2 + " and its good!");
// Console.WriteLine($"My namber are {number1} and {number2} and its good!");

// -----------------------


// функционал Console.ReadLine()

// Console.Write("Imput an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your namber is " + num);

//---------------------------

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
/*
Console.Write("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2) 
{
    Console.WriteLine("Yes");
}    
else
{
    Console.WriteLine("No");
}    
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N),
// а на выход показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Imput a first number: ");
int n = Convert.ToInt32(Console.Readline());
 
int current = -n;

while(current <= n)
{
    Console.Write(cuttent + " ");
    current++;
}
*/

// Домашнее задание.
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}    
Console.WriteLine("max = " + max);
*/

// Задача 4. Напишите программу,которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
/*
Console.WriteLine("input three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}    
if (num3 > max)
{
    max = num3;
}    
Console.WriteLine(max); 
*/

// Задание 6: Напишите программу, которая на вход принимает число и выдаёт, 
// являеться ли число чётным (делиться ли оно на два без остатка).
/*
Console.WriteLine("Iput a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write(num + " - Чётное");
}    
else
{
    Console.Write(num + " - Нечётное");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Imput a first number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
{

    if (current % 2 == 0)
    {

        Console.Write(current + ", ");

    }
    current++;

}
*/