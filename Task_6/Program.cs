﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число, ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число нечётное");
