﻿//  Задача 14.
// Напишите программу, которая
// 1. Принимает на вход число и
// 2. проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет 
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 7 == 0) & (number % 23 == 0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
//if((number % 7 == 0) && (number % 23 == 0));
//Console.WriteLine("Число кратно 7 и 23");
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
