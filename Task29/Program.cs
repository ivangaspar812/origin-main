/*
29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] createArray(int 8, int 10, int 50);

Print(array);


int[] array = new int[size];

var random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(minValue, maxValue);
}
return array;

void Print(int[] array)
{
foreach (int i in array)
{
    System.Console.WriteLine(I + " ");
}
}