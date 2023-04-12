
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int A = 2;
int B = 3;
int C = 7;

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.WriteLine(max);