//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int rows = 8; int columns = 3;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    return matrix;
}

void SwapFirstAndLastRow(int[,] forArr)
{
    int rowCount = forArr.GetLength(0);
    int columnCount = forArr.GetLength(1);
    for (int j = 0; j < columnCount; ++j)
    {
        int temp = forArr[0, j];
        forArr[0, j] = forArr[rowCount - 1, j];
        forArr[rowCount - 1, j] = temp;
    }
}

void PrintMatrixInts(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MyMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
SwapFirstAndLastRow(MyMatrix);
Console.WriteLine();
PrintMatrixInts(MyMatrix);
Console.WriteLine();
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] MatrizenTransponieren(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    int[,] MatrixT = new int[columnCount,rowCount];
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
        {
            MatrixT[j,i] = matrix[i,j];
        }
    return MatrixT;
}
Console.WriteLine("Task #50");
int[,] MyMatrixNew = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
Console.WriteLine();
int[,] MatrixT = MatrizenTransponieren(MyMatrix);
PrintMatrixInts(MatrixT);
