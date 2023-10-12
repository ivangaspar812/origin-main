/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите день недели: ");
int dayNumber = int.Parse(System.Console.ReadLine());

string[] daysArray = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

System.Console.WriteLine("День недели " + daysArray[dayNumber - 1]);
