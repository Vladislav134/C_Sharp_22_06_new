// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
int count = 0;
while (m <= n)
{
    if (m%2 == 0)
    count++;
m++;
}
Console.WriteLine($"Четных чисел {count}");