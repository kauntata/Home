//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int Length = 8;
int sum = 0;
int[] array= new int[Length];
RandomNumbers(array);
PrintArray(array);
CalculatetSum(array);

Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях -> {sum} ");
void CalculatetSum(int[] array)
{
     for (int i = 0; i < Length; i++)
   {
        if (array[i] % 2 > 0)
        {
        sum += array[i];
        }
    
    }
}

void RandomNumbers(int[] array)
{
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(0,100);
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