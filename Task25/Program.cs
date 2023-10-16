/*
25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 

Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

double Math.Pow(double firstNumber, double secondNumber);
{
    result = firstNumber^secondNumber;
    System.Console.Write(result);
}
System.Console.WriteLine(Math.Pow(firstNumber, secondNumber));