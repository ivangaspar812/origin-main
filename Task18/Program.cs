﻿/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();

System.Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    System.Console.WriteLine("X > 0 и Y > 0");
}
else if (number == 2)
{
    System.Console.WriteLine("X < 0 и Y > 0");
}
else if (number == 3)
{
    System.Console.WriteLine("X < 0 и Y < 0");
}
else if (number == 4)
{
    System.Console.WriteLine("X > 0 и Y < 0");
}
else if (number < 1 || number > 4)
{
    System.Console.WriteLine("Нет такой четверти");
}
