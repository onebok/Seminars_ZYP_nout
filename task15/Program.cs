﻿//  Задача 15.
// Напишите программу, которая принимает на вход
// 1. цифру, обозначающую день недели,
// 2. и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите целое число от 1 до 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if ((weekDay >= 1 & weekDay <= 5))
{
   Console.WriteLine("Рабочий день"); 
} 
   
if (weekDay == 6 || weekDay == 7)
{
   Console.WriteLine("Выходной день");  
}

if (weekDay < 1)
{
   Console.WriteLine("Число введено неверно "); 
}
if (weekDay >7)
{
   Console.WriteLine("Число введено неверно"); 
}
// Почему-то не срабатывает запись
// if (weekDay < 1 && weekDay >7)
// {
//    Console.WriteLine("Число введено неверно"); 
// }
