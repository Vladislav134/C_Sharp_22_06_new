// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a%2 == 0)
Console.WriteLine($" {a} Четное число");
else 
Console.WriteLine($" {a} Нечетное число");
