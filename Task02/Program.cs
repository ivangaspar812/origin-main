﻿/*
Внутри класса Answer напишите метод CompareNumbers, 
который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/
System.Console.WriteLine("Введите два числа: ");
int firstNumber = 
int secondNumber = 
if(firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
}
else if(secondNumber < firstNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
else if(firstNumber == secondNumber)
{
    System.Console.WriteLine($"Введенные числа равны {firstNumber}");
}