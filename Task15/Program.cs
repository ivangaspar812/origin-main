/*
15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 7 || dayNumber == 6)
{
    System.Console.WriteLine("Это выходной день");
}
else if (dayNumber > 0 && dayNumber < 6)
{
    System.Console.WriteLine("Это будний день");
}
else 
{
    System.Console.WriteLine("Такого дня недели не существует");
}