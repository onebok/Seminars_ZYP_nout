﻿//Задача 12. 
//Напишите программу, которая
// 1. будет принимать на вход два числа и
// 2. выводить, является ли первое  число кратным второму
// 3. Если число 1  не кратно числу 2, то программа выводит 
// остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// 
Console.WriteLine("Введите первое число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
//
//     Console.WriteLine(((number1 % number2) == 0) true ? ((number1 % number2) == 0) false);
//
// }
    return number1 % number2 == 0;
}
if (DivCheck (userNumber, userNumber2))
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> кратно");
}
else
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> не кратно, остаток " + (userNumber % userNumber2));
}
