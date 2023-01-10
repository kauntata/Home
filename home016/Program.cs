// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

int size = 8;

int[] array= new int[size];
RandomNumbers(array);
int maxArray = array[0];
int minArray = array[0];
PrintArray(array);
MaxMinArray(array);



void MaxMinArray(int[] array)
{
     for (int i = 0; i < size; i++)
   {
        if (array[i] > maxArray)
        {
             maxArray = array[i];
        }
   
        else if (array[i] < minArray);
        {
             minArray = array[i];
        }

    }
}
Console.WriteLine($"максимальный -> {maxArray} ");
Console.WriteLine($"минимальный -> {minArray} ");


Console.WriteLine($"разницу между максимальным и минимальным-> {maxArray - minArray} ");
void RandomNumbers(int[] array)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}


void PrintArray(int[] array)
{
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}