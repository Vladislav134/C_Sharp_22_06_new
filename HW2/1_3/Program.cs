// See https://aka.ms/new-console-template for more information
void TakeNum(int Num)
{
    if (Num < 6 && Num > 0)
    {
        Console.WriteLine("Нет");
    }
    else if (Num>5 && Num<8)
    {
        Console.WriteLine("Да");
            }
    else 
        Console.WriteLine("Введеное число неверно");
}
int NumA = int.Parse(Console.ReadLine()!);
TakeNum(NumA);
