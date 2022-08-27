// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();

char[]n = str.ToCharArray();

if (n[0]==n[4] || n[1]==n[3])
{
    Console.WriteLine("да");
 }

else
{ 
    Console.WriteLine("нет");
    }
