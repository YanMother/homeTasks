﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = 2;
int numberB = 10;

int max = numberA;
int min = numberA;
if (numberA > max) max=numberA;
if (numberB > max) max=numberB;

Console.WriteLine(max);
Console.WriteLine(min);
