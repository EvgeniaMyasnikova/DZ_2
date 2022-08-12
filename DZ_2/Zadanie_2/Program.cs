/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.WriteLine("Введите число: ");

int result = Convert.ToInt32(Console.ReadLine());

if (result < 100)
{
    Console.WriteLine("Третьей цифры нет"); 
}
if (result >= 100)
{
    string number = Convert.ToString (result);
    Console.WriteLine(number[2];
}

*/

string? number = Console.ReadLine();
int size = number.Length;

if (size < 3)
{
    Console.WriteLine("Третьего символа нет");
}
if (size >= 3)
{
    Console.WriteLine(number[2]);
}

