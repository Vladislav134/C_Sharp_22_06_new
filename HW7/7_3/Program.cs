int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];


    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]},   ");
        }
        Console.WriteLine();
    }
}

void AveMatrix(int[,] matrix)
{
    int AveNum;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int Sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum = Sum + matrix[i, j];
        }
        AveNum = Sum / matrix.GetLength(1);
        Console.WriteLine($"AverageCol_{j+1}={AveNum}");
    }
}

Console.WriteLine("Введите количество строк");
int rowCount = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columnCount = int.Parse(Console.ReadLine()!);
int[,] matrix = CreateMatrix(rowCount, columnCount);
ShowMatrix(matrix);
AveMatrix(matrix);