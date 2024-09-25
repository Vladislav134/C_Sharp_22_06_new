
int[,] CreateMatrix (int rowCount, int columnCount)    
{
    int[,] matrix = new int [rowCount, columnCount];


    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,11);
        }
    }
    return matrix;
}

int[,] CreateMatrix2 (int rowCount, int columnCount)

{
    int[,] matrix2 = new int [rowCount, columnCount];

    Random rnd = new Random();
    for (int x = 0; x < matrix2.GetLength(0); x++)
    {
        for (int y = 0; y < matrix2.GetLength(1); y++)
        {
            matrix2[x,y] = rnd.Next(1,11);
        }
    }
    return matrix2;
}    

void ShowMatrix (int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ShowMatrix2 (int[,] matrix2)
{
    for ( int x = 0; x < matrix2.GetLength(0); x++)
    {
        for (int y = 0; y < matrix2.GetLength(1); y++)
        {
            Console.Write($"{matrix2[x,y]} ");
        }
        Console.WriteLine();
    }
}
    
int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);
int[,] matrix2 = CreateMatrix2(4,5);
ShowMatrix2 (matrix2);

for ( int x = 0; x < matrix2.GetLength(0); x++) 
   {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int y = 0; y < matrix2.GetLength(1); y++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[x,y] = matrix[i,j];
        }
    }           
   }       
   }
void ShowMatrix3 (int[,] matrix2) 
{ 
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            Console.Write($"{matrix[x,y]} ");
        }
        Console.WriteLine();
    }
}     
ShowMatrix3 (matrix2);