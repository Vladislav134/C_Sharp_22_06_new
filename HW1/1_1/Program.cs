// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
if ( a > b)
            {
Console.WriteLine("{0} наибольшее число", a);
            }
else if ( b > a) 
{
    Console.WriteLine("{0} Наибольшее число", b);
            }  
else 
{
            Console.WriteLine("числа равны");        
        }

