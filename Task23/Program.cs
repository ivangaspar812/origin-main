﻿/*
23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine(i*i*i + " ");
}