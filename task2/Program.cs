// адача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 
// 645 -> 6
// 
// 78 -> третьей цифры нет
// 
// 32679 -> 6
using System;
using static System.Console;

string findThirdNum (int num)
{
   return num >= 100 ? $"Третье число: {(num/100)%10}" : "третьей цифры нет";
}
Console.Clear();

Write("Введите число: ");
WriteLine(findThirdNum(Convert.ToInt32(ReadLine())));


