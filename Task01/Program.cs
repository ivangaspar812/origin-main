/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

System.Console.Write("Введите число 1: ");
int number1 = int.Parse(System.Console.ReadLine());

System.Console.Write("Введите число 2: ");
int number2 = int.Parse(System.Console.ReadLine());

if(number2 * number2 == number1)
{
    System.Console.WriteLine("Число 2 является квадратом числа 1");
}
else
{
    System.Console.WriteLine("Число 2 не является квадратом числа 1");
}
