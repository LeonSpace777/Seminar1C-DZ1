﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a;
int b;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("Большее число = ");
    Console.WriteLine(a);
    Console.Write("Меньшее число = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine(b);
    Console.Write("Меньшее число = ");
    Console.WriteLine(a);
}
