﻿// Задача 01
// Напишите программу, которая
// 1. на вход принимает два числа
// и
// 2. проверяет, является ли первое число, квадратом второго
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет


Console.WriteLine("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square2 = number2*number2;
if (number1 ==  number2*number2)
{
  Console.WriteLine($"Первое число является квадратом второго {number2} = {square2}");
}
else
{
    Console.WriteLine($"Первое число не является квадратом второго {number2} = {square2}");
}
