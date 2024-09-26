
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

string FindMatrix(int[,] matrix, int RowNum, int ColNum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i+1==RowNum && j+1==ColNum)
            return $"{matrix[i,j]}";
        }
    }
    return "No such element";
}

Console.WriteLine("Введите количество строк");
int rowCount = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columnCount = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение строки элемента");
int RowNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение столбца элемента");
int ColNum = int.Parse(Console.ReadLine()!);
int [,] matrix = CreateMatrix(rowCount, columnCount);
ShowMatrix(matrix);
Console.WriteLine(FindMatrix(matrix, RowNum, ColNum));