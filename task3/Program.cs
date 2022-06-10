// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 
// 6 -> да
// 7 -> да
// 1 -> нет

using System;
using static System.Console;

string isWeekend (int num)
{
   return num == 6 || num == 7 ? "Да" : "Нет";
}
Console.Clear();

Write("Введите номер дня недели: ");
WriteLine(isWeekend(Convert.ToInt32(ReadLine())));


