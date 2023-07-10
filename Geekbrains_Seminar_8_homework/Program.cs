/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

const int rows = 5;
const int columns = 10;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] luck = new int[rows, columns];
    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
        {
            luck[i, j] = Random.Shared.Next(1, 11);
        }
    return luck;
}

int[,] ReturnSortedByRows(int[,] matrix)
{
    for (int i = 0; i < rows; ++i)
        for (int j = 0; j < columns; ++j)
            for (int k = 0; k < columns; ++k)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; ++i)
    {
        for (int j = 0; j < columns; ++j)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
int[,] matr = GetRandomArray(rows, columns);
PrintMatrix(ReturnSortedByRows(matr));
/*OUTPUT:
1 1 2 5 6 7 9 9 10 10
2 3 4 5 7 8 8 9 10 10
1 1 1 3 3 4 4 5 8 10
1 4 4 5 5 5 9 10 10 10
3 4 4 5 5 8 9 9 9 10
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int NumberOfStringInArray(int[,] Matrix)
{
    int SumMinimal = int.MaxValue;
    int indexToMinRowSum = 0;
    for (int i = 0; i < rows; ++i)
    {
        int MinAcrossRow = 0;
        for (int j = 0; j < columns; ++j)
        {
            MinAcrossRow += Matrix[i, j];
        }
        if (MinAcrossRow < SumMinimal)
        {
            SumMinimal = MinAcrossRow;
            indexToMinRowSum = i;
        }
    }
    return indexToMinRowSum;
}

/*
int[,] matr = GetRandomArray(rows, columns);
PrintMatrix(matr);
Console.WriteLine(NumberOfStringInArray(matr));
/*OUTPUT:
10 1 3 4 8 1 7 8 6 4            (0)
2 10 8 2 10 10 10 8 4 3         (1)
10 10 1 2 10 8 4 10 8 1         (2)
10 5 9 9 4 6 10 3 1 2           (3)
8 4 5 1 8 2 1 9 4 5             (4)

4
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6
*/
int[,] MatrixEntryByEntryMultiplication(int[,] m1, int[,] m2)
{
    int rows_m1 = m1.GetLength(0);
    int columns_m1 = m1.GetLength(1);
    int rows_m2 = m2.GetLength(0);
    int columns_m2 = m2.GetLength(1);
    if (rows_m1 != rows_m2 || columns_m1 != columns_m2)
        throw new Exception("Matrices dimensions mismatch");
    try
    {
        int[,] m_Product = new int[rows_m1, columns_m1];
        for (int i = 0; i < rows_m1; ++i)
            for (int j = 0; j < columns_m1; ++j)
                m_Product[i, j] = m1[i, j] * m2[i, j];
        return m_Product;
    }
    catch
    {
        throw new Exception("Memory resources in your OEM are insufficient");
    }
}
int[,] Matrix_1 = GetRandomArray(rows, columns);
PrintMatrix(Matrix_1);
int[,] Matrix_2 = GetRandomArray(rows, columns);
PrintMatrix(Matrix_2);
int[,] Matrix_12_Product = MatrixEntryByEntryMultiplication(Matrix_1, Matrix_2);
PrintMatrix(Matrix_12_Product);

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

const int dim1 = 2, dim2 = 3, dim3 = 2;

int[,,] oregon_Matrix(int dimension_1, int dimension_2, int dimension_3)
{
    int[,,] New_Oregon_Matrix = new int[dimension_1, dimension_2, dimension_3];
    for (int i = 0; i < dimension_1; ++i)
        for (int j = 0; j < dimension_2; ++j)
            for (int k = 0; k < dimension_3; ++k)
            {
                New_Oregon_Matrix[i, j, k] = Random.Shared.Next(10, 100);
            }
    return New_Oregon_Matrix;
}

void Print_Oregon_Matrix(int[,,] oregonMatrix)
{
    int NewOregon_dimension_1 = oregonMatrix.GetLength(0);
    int NewOregon_dimension_2 = oregonMatrix.GetLength(1);
    int NewOregon_dimension_3 = oregonMatrix.GetLength(2);
    for (int i = 0; i < NewOregon_dimension_1; i++)
    {
        for (int j = 0; j < NewOregon_dimension_1; j++)
        {
            for (int k = 0; k < NewOregon_dimension_1; k++)
            {
                Console.Write(oregonMatrix[i, j, k] + $" ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] Margin_P = oregon_Matrix(dim1,dim2,dim3);
Print_Oregon_Matrix(Margin_P);
/*OUTPUT:
79 (0, 0, 0) 18 (0, 0, 1) 56 (0, 1, 0) 74 (0, 1, 1)
30 (1, 0, 0) 44 (1, 0, 1) 35 (1, 1, 0) 84 (1, 1, 1)
/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/**
Indices order:
(0,0) (0,1) (0,2) (0,3)
(1,3) (2,3) (3,3) 
(3,2) (3,1) (3,0)
(2,0) (1,0) 
(1,1) (1,2)
(2,2) (2,1)
**/
int[,] SpiralMatrix(int Dim_quadratic)
{
    int[,] Matrix_Q = new int[Dim_quadratic, Dim_quadratic];
    int ElementCounter = 0;
    int HorizI = 0;
    int VerticJ = 0;
    for (int i = 0; i < (Dim_quadratic+1)/2;++i)
    {
        for (int j = 0; j < 4*Dim_quadratic - 3; ++j)
        {
            Matrix_Q[HorizI,VerticJ] = ElementCounter++;
        }  
    }
    return Matrix_Q;
}

// Задача 59. Вывести треугольник Паскаля!
/*
Dimensions:

[0,0,0,1,0,0,0]
[0,0,1,0,1,0,0]
[0,1,0,2,0,1,0]
[1,0,3,0,3,0,1]
[0,0,0,1,0,0,0]
*/

//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
/*
3 строки: - 5 столбцов
00100
01010
10201

5 строк: - 9 столбцов
000010000
000101000
001020100
010303010
104060401
*/
const uint N = 5;

void PrintMatrixInts(uint[,] matrix)
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

uint[,] PascalOutTriangleI(uint Nrows)
{
    uint ColsCount = Nrows * 2 - 1;
    uint[,] PascalMatrix = new uint[Nrows, ColsCount];
    for (int j = 0; j < PascalMatrix.GetLength(0); ++j)
    {
        for (int i = 0; i < PascalMatrix.GetLength(0); ++i)
        {
            PascalMatrix[i, PascalMatrix.GetLength(1) / 2 + i] = 1;
            PascalMatrix[i, PascalMatrix.GetLength(1) / 2 - i] = 1;
            if (j >= 2)
            {
                PascalMatrix[i,PascalMatrix.GetLength(1) / 2 - i] = PascalMatrix[i-1, PascalMatrix.GetLength(1) / 2 - i-1] + PascalMatrix[i-1, PascalMatrix.GetLength(1) / 2 + i-1];
                PascalMatrix[i,PascalMatrix.GetLength(1) / 2 + i] = PascalMatrix[i-1, PascalMatrix.GetLength(1) / 2 - i-1] + PascalMatrix[i-1, PascalMatrix.GetLength(1) / 2 + i-1];
            }
        }
    }
    return PascalMatrix;
}

uint[,] Pascal2DArray = PascalOutTriangleI(N);
PrintMatrixInts(Pascal2DArray);