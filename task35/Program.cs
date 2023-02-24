//Задача 35.
// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [10,99]. 

int[] newArr = RandomArray(123);
PrintArray(newArr);
System.Console.WriteLine(FindNumInInterval(newArr, 10, 99));


int FindNumInInterval(int[] array, int num1, int num2)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= num1 && array[i] <= num2)
        {
            count++;
        }
    }
    return count;
}



int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(1,1000);
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
