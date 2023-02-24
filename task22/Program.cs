// Задача 22
// Напишите программу, которая
// 1. принимает на вход число (N) и выдает таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.


Console.WriteLine("Введите натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());

squareNumber(num);

void squareNumber(int number) 
{
    int index = 1;
    while (index <= number);
    {
    index++;
    Console.WriteLine($"{index} -> {index*index}");
    }
}

