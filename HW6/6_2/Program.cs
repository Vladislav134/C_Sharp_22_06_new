int PozNum(int num)
{
    int pozqount = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Vvedite hislo");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0)
            pozqount = pozqount + 1;
    }
    return pozqount;
}
int result = PozNum(5);
Console.WriteLine($"Kol. polozhit. chisel: {result}");