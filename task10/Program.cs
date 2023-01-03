﻿//  Задача 10.
// Напишите программу, которая на вход
// 1. принимает трехзначное число и
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918  -> 1
// 

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 100 && number <=1000) || (number >= -1000 && number <=-100))
{
   Console.WriteLine($"Вторая цифра введенного числа {(number /10)% 10} ");
}
else
{
    Console.WriteLine("Число не трехзначное");
}

