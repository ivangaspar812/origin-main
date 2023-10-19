/*
19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Clear();

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
/*
int n1 = number / 10000;
int n2 = number / 1000 % 10;
int n4 = number / 10 % 10;
int n5 = number % 10;
if (number >= 10000 && number <= 99999)
{
    if (n1 == n5 && n2 == n4)
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}
else 
{
    System.Console.WriteLine("This is not a five digit!");
}
*/

int revN = 0;
for (int i = number; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
}
if (number == revN)
{
    System.Console.WriteLine("Yes");
}
else System.Console.WriteLine("No");