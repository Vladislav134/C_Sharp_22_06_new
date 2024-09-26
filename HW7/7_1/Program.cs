double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] matrix = new double[rowCount, columnCount];


    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(-10, 10) * 0.1, 2);
        }
    }
    return matrix;
}

void ShowMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rowCount = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columnCount = int.Parse(Console.ReadLine()!);
double[,] matrix = CreateMatrix(rowCount, columnCount);
ShowMatrix(matrix);
