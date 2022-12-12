﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
double x = -5;
while(k1*x+b1 != k2*x+b2)
{
   x+= 0.5;
}
Console.WriteLine($"y = {(k1 * x) + (b1)} x = {x}");