﻿// Задача 03
//Напишите программу, 
// 1. будет выдавать название дня недели
// по заданному номеру
// 3 -> среда
// 5 -> пятница


Console.WriteLine("Введите целое число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("День недели понедельник");
}
else if (day == 2)
{
    Console.WriteLine("День недели вторник");
}
else if (day == 3)
{
    Console.WriteLine("День недели среда");
}
else if (day == 4)
{
    Console.WriteLine("День недели четверг");
}
else if (day == 5)
{
    Console.WriteLine("День недели пятница");
}
else if (day == 6)
{
    Console.WriteLine("День недели суббота");
}
else if (day == 7)
{
    Console.WriteLine("День недели воскресенье");
}
else
{
    Console.WriteLine("Число введено неверно");
}
