﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трёхзначное число ");
string str = Console.ReadLine();

char[]c = str.ToCharArray();
if (str.Length>2)
{
    Console.WriteLine(" третья цифра " + c[2]);
}
else
{ 
    Console.WriteLine(" третьей цифры нет ");
    }