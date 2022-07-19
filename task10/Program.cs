﻿/*
программа принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число:");
int firstNum = int.Parse(Console.ReadLine());

int secondNum = firstNum / 100;
int thirdNum = firstNum % 10;

if (Math.Abs(firstNum) > 99 && Math.Abs(firstNum) < 1000)
{
    Console.WriteLine((firstNum % 100-thirdNum)/10);
}
else
{
    Console.WriteLine("Число не является трех значным");
}
