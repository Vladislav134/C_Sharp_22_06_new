Console.WriteLine("Введите три числа: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int Maks;
if (a > b && a > c)
{ Maks = a}
if (b > a && b > c)
{ Maks = b}
if (c > a && c > b)
{Maks = c}
print(Maks);
