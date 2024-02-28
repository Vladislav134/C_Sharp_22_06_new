// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);
if (n/10000 + n/1000%10 == n%100/10 + n%10)
        Console.WriteLine($"Число {n} палиндром");

else Console.WriteLine($"Число ${n} не палиндром");    

