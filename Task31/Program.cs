/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве 
[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int SumPositiv(int[] abrakadabra)
{
    int sum = 0;
for (int i = 0; i < abrakadabra.Length; i++)
{
    if (abrakadabra[i]>0)
    {
        sum = abrakadabra[i] + sum;
    }
}
    return sum;
}

int SumNegativ(int[] ahalaimahalai)
{
    int sum = 0;
for (int i = 0; i < ahalaimahalai.Length; i++)
{
    if (ahalaimahalai[i]<0)
    {
        sum = ahalaimahalai[i] + sum;
    }
}
    return sum;
}

int[] arr = CreateArray(12, -9, 9);

Output(arr);

int sump = SumPositiv(arr);
int sumn = SumNegativ(arr);
System.Console.WriteLine();
Console.WriteLine($"Сумма положительных равна: {sump}, Сумма отрицательных равна: {sumn}");