﻿// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Pow(double number, int power)
{
    double res = 1;
    for (int i = 1; i <= power; i++)
    {
        res *= number;
    }
    return res;
}

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

Pow(num, pow);
Console.WriteLine($"{num} в степени {pow} = {Pow(num, pow)}");
