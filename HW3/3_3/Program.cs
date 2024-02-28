// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
if (n >= 0)
{
    int count = 1;
    while (count <= n)
    {
        double result = Math.Pow(count, 3);
        count++;
        Console.WriteLine("Значение = " + result);
    }
}
else
{
    int count = -1;
    while (count >= n)
    {
        double result = Math.Pow(count, 3);
        count--;
        Console.WriteLine("Значение = " + result);
    }
}
