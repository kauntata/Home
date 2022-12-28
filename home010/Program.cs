Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);
int c= ((n%10)*10);
int a = ((n%100)/10);
int b = (n/1000);
int b1 = (a + c);
if(10000<n)
{
    if (n<100000)
    {
       if(b == b1)
       {
        Console.Write ($" Число является палиндромом ");
       }
        else Console.Write ($" Число не является палиндромом ");
    }
    else  System.Console.WriteLine("Введено неверно  значение");
}
else  System.Console.WriteLine("Введено неверно  значение");

