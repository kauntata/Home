//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int Length = int.Parse(Console.ReadLine()!);
int[] array = new int[Length];
int count = 0;
RandomNumbers(array);
PrintArray(array);

for (int i = 0; i < Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}




Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

void RandomNumbers(int[] array)
{
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}