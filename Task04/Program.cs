/*
Внутри класса Answer напишите метод FindMax, который 
принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите 3 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int result = number1;

if(number2 > result)
{
    result = number2;
}
if(number3 > result)
{
    result = number3;
}
System.Console.WriteLine($"Максимальное число - это {result}");
