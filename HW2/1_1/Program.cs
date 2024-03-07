// See https://aka.ms/new-console-template for more information
void TakeNum(int Num)
{
    if (Num < 100 && Num > 999)
    {
        Console.WriteLine("Введите другое число");
    }
    else
    {
        Num = Num / 10 % 10;
        Console.WriteLine(Num);
        
    }
}
int NumA = int.Parse(Console.ReadLine()!);
TakeNum(NumA);
