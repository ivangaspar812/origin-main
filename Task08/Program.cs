﻿/*
Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/
System.Console.WriteLine("Введите любое число: ");

for (int i = 2; i <= number; i+=2)
{
    System.Console.Write(i + "\t");
}