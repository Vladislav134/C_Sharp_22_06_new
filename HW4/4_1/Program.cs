// See https://aka.ms/new-console-template for more information
int Degr(int num, int deg)
{
int DegNum = 1;
    for (int i = 1; i <= deg; i++)
        {
            DegNum = DegNum * num;
        }
return DegNum;
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int result = Degr(a, b);
Console.WriteLine(result);
