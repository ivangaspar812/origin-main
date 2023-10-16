/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
int num = 292452;
System.Console.WriteLine(AmountNumbers(num));

int AmountNumbers(int num)
{
    int count = 0;
    while (num > 0)
    {
    num = num / 10;
    count++;
    }
    return count;
}