/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// Console.WriteLine ("Введите трехзначное число");

// string? number = Console.ReadLine();

// Console.WriteLine(number[1]);

// 


Console.WriteLine ("Введите трехзначное число");
int digit = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString (digit);
Console.WriteLine(number[1]);
