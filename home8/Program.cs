Console.WriteLine("Ввидите n");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= n; i++)
{
if (i == n){Console.Write($"{Math.Pow(i, 3)}");}
else Console.Write($"{Math.Pow(i, 3)}, ");

}