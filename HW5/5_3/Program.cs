void Print(double[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
double[] arr = new double[size];
Random n_new = new Random();

for (int i = 0; i < size; i++)
arr[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
return arr;
}

void Razn(double[] arr)
{
double raznica, max, min;
raznica = max = min = 0;

for (int i = 0; i < arr.Length - 2; i++)
{
if (arr[i] > arr[i+1])
max = arr[i];
else max = arr[i+1];
if (arr[i] < arr[i+1])
min = arr[i];
else min = arr[i+1];
}
raznica = max - min;
Console.Write($"max: {max}, min: {min}. ");
Console.WriteLine($"Raznica: {max} - {min} = {Math.Round(max - min)}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
Razn(mass);
