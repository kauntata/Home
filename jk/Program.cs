
Console.WriteLine("Введите число от 100 до 999");
int n = int.Parse(Console.ReadLine()!);
int c = 0;
if (n > 99)
{
    if(n < 999)
    {
        c = n%10;
     System.Console.WriteLine(c);
    }
    else
    System.Console.WriteLine("Третьей цифры нет");
}
else System.Console.WriteLine("Третьей цифры нет");
