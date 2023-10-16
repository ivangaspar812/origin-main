/*
29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] newArray = NewArrayFilledRandom();

PrintArray(newArray);





void PrintArray(int[] arr)
{
    foreach( int i in arr)
        System.Console.Write(i + "\t");
}

int[] NewArrayFilledRandom()
{
    int[] arr = new int[8];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}