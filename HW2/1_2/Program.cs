// See https://aka.ms/new-console-template for more information
void TakeNum(int Num)
{
    if (Num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else 
    {   while (Num > 1000)  
            {
                Num = Num / 10;
            }
        Num = Num % 10;
        Console.WriteLine(Num);
    }
}    
int A = int.Parse(Console.ReadLine()!);
TakeNum(A);    