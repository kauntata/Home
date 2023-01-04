Console.WriteLine("Введите два числа A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите два числа B");
int B = int.Parse(Console.ReadLine()!);
int C = 1;
for(int i = B; i > 0; i--)
{
    C = (C*A);
} 
System.Console.WriteLine(C);