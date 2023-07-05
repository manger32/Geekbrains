/**
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 2 -> 2

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
**/

/**47**/

double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

double[,] GetRandomMatrix(int rows, int columns)
{
    double [,] Matrix = new double[rows,columns];
    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
        {
            double rnd = GetRandomNumber(1,100);
            Matrix[i,j] = rnd;
        }
    return Matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

/*double[,] Matr = GetRandomMatrix(2,2);
PrintMatrix(Matr);
/*OUTPUT
71,33782045222141       81,61837016493327
33,22044831142062       49,57779103535194
*/

/**50**/
Int64[,] GetRandomMatrixInts(int rows, int columns)
{
    Int64 [,] Matrix = new Int64[rows,columns];
    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
        {
            Int64 rnd = Random.Shared.NextInt64(1,100);
            Matrix[i,j] = rnd;
        }
    return Matrix;
}

void PrintMatrixInts(Int64[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

string ExistsInMatrix(Int64 [,] Matrix, int g, int q)
{
    if (g-1 >= Matrix.GetLength(0) || q-1 >= Matrix.GetLength(1) || g < 0 || q < 0)
        return "Such an Element does not exist, because indices do not exist";
    return Matrix[g-1,q-1].ToString();
            
}

Int64[,] MatricesDelusion = GetRandomMatrixInts(2,2);
PrintMatrixInts(MatricesDelusion);
Console.WriteLine(ExistsInMatrix(MatricesDelusion, 7, 2));

/**52**/
Int64[,] GetRandomMatrixInts64(int rows, int columns)
{
    Int64 [,] Matrix = new Int64[rows,columns];
    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
        {
            Int64 rnd = Random.Shared.NextInt64(1,100);
            Matrix[i,j] = rnd;
        }
    return Matrix;
}

Int64[] StandardMeanColumnVector(Int64[,] matrix)
{
    Int64[] StandardMean = new Int64[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            StandardMean[j] += matrix[i,j];
        }
        
    for (int j = 0; j < matrix.GetLength(1); ++j)
        StandardMean[j] /= matrix.GetLength(0);
    return StandardMean;
}
Int64[,] Matrixx = GetRandomMatrixInts64(9,9);
PrintMatrixInts(Matrixx);
Int64[] stdMean = StandardMeanColumnVector(Matrixx);
Console.WriteLine("Standard mean arithmetic values: ");
Console.WriteLine(String.Join('\t', stdMean));