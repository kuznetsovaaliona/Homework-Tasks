﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32 (Console.ReadLine());

//if (num1>num2)
//{
//     Console.WriteLine ("MAx = First number, Min = Second number");
//}
//else
//{
//   Console.WriteLine ("Max = Second number, Min = First number");
//}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("Input third number");
//int num3 = Convert.ToInt32 (Console.ReadLine());
//int max = num1;
//if (num2>max)
//max=num2;

//if (num3>max)
//max=num3;

//Console.WriteLine (max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// void Even (int num1)
// {
//     int rez = num1%2;

//     if (rez==0)
//     {
//         Console.WriteLine ($"Четное число");
//     }
//     else
//     {
//         Console.WriteLine ($"Нечетное число");
//     }
// }
// Even (9);

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Input number");
int num = Convert.ToInt32 (Console.ReadLine());
int current = 1;
if (num<0)
num=num*(-1);
while (current<=num)
{
    int rez = current%2;
    if (rez==0)
    {
        Console.Write(current + " ");
        current++; 
    }
    else
    {
        Console.WriteLine (" ");
        current++;
    }
    
}

