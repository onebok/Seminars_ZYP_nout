//Задача 31
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] newArr = RandomArray(12);
PrintArray(newArr);
System.Console.WriteLine(GetSumLessZero(newArr));
System.Console.WriteLine((newArr));

int GetSumMoreZero(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
            if(array[i] >= 0)
            {
            result += array[i];
            }
    }
    return result;
}

int GetSumLessZero(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
            if(array[i] < 0)
            {
            result += array[i];
            }
    }
    return result;
}

int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(-9,10);
     }
     return arr;
}

void PrintArray(int[] arr)
{    
    foreach(int item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}
