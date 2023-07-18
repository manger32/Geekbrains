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
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
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
/*int[,] Matrix_1 = GetRandomArray(rows, columns);
PrintMatrix(Matrix_1);
int[,] Matrix_2 = GetRandomArray(rows, columns);
PrintMatrix(Matrix_2);
int[,] Matrix_12_Product = MatrixEntryByEntryMultiplication(Matrix_1, Matrix_2);
PrintMatrix(Matrix_12_Product);
/*OUTPUT:
6 10 5 3 10 9 1 9 9 10 
3 1 3 2 8 1 8 3 8 1
5 10 1 1 10 1 4 3 5 7
8 8 6 10 10 9 2 3 2 10
10 4 5 7 9 1 1 1 9 5

9 10 7 3 3 5 4 2 3 5
10 3 8 2 10 7 2 6 3 2
5 3 5 5 7 5 5 6 5 10
4 6 10 7 8 4 10 4 6 4
6 6 7 4 8 7 1 10 10 1

54 100 35 9 30 45 4 18 27 50
30 3 24 4 80 7 16 18 24 2 
25 30 5 5 70 5 20 18 25 70
32 48 60 70 80 36 20 12 12 40
60 24 35 28 72 7 1 10 90 5
*/


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
// O(N^3)
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
    int ElementCounter = 1;
    int VerticI = 0;
    int HorizJ = 0;
    bool NowHorizontal = true;
    bool Backwards = false;
    bool NowVertical = false;
    bool Upwards = false;
    for (int i = 0; i < (Dim_quadratic + 1) / 2; ++i)
    {
        for (int j = 0; j < 4 * (Dim_quadratic - i) - (3 + i); ++j)
        {
            Matrix_Q[VerticI, HorizJ] = ElementCounter++;
            //Console.WriteLine(Matrix_Q[VerticI, HorizJ] + " "); // Debug String
            if (NowHorizontal)
                if (Backwards)
                    HorizJ--;
                else
                    HorizJ++;
            if (NowVertical)
                if (Upwards)
                    VerticI--;
                else
                    VerticI++;
            if (HorizJ == i && NowHorizontal)
            {
                NowVertical = true;
                NowHorizontal = false;
                if (Backwards)
                    Backwards = false;
                else
                    Backwards = true;
            }
            if (VerticI == i && NowVertical)
            {
                NowVertical = false;
                NowHorizontal = true;
                if (Upwards)
                    Upwards = false;
                else
                    Upwards = true;
            }
            if (HorizJ == Dim_quadratic - i - 1 && NowHorizontal)
            {
                NowVertical = true;
                NowHorizontal = false;
                if (!Backwards)
                    Backwards = true;
                else
                    Backwards = false;
            }
            if (VerticI == Dim_quadratic - i - 1 && NowVertical)
            {
                NowVertical = false;
                NowHorizontal = true;
                if (!Upwards)
                    Upwards = true;
                else
                    Upwards = false;
            }
        }
    }
    return Matrix_Q;
}

int[,] SpiralMatrixSecondAttempt(int N)
{
    int Dim_quadratic = N;
    var SpiralMatrix = new int[Dim_quadratic, Dim_quadratic];
    int AllElems = (int)Math.Pow(Dim_quadratic, 2);
    int KeyToMatrix_1 = 1;
    int IndexToSpiral = 0;
    while (Dim_quadratic != 0)
    {
        for (int t = 0; t < 4; ++t)
        {
            for (int l = 0; l < Dim_quadratic; ++l)
            {
                if (t == 0 && l < Dim_quadratic - IndexToSpiral && KeyToMatrix_1 <= AllElems)
                    SpiralMatrix[t + IndexToSpiral,l + IndexToSpiral] = KeyToMatrix_1++;
                if (t == 1 && l < Dim_quadratic - IndexToSpiral && l != 0 && KeyToMatrix_1 <= AllElems)
                    SpiralMatrix[l + IndexToSpiral,Dim_quadratic - 1] = KeyToMatrix_1++;
                if (t == 2 && l < Dim_quadratic - IndexToSpiral && l != 0 && KeyToMatrix_1 <= AllElems)
                    SpiralMatrix[Dim_quadratic - 1,Dim_quadratic - (l + 1)] = KeyToMatrix_1++;
                if (t == 3 && l < Dim_quadratic - (IndexToSpiral + 1) && l != 0 && KeyToMatrix_1 <= AllElems)
                    SpiralMatrix[Dim_quadratic - (l + 1),IndexToSpiral] = KeyToMatrix_1++;
            }
        }
        Dim_quadratic--;
        IndexToSpiral++;
    }
    /**
    Not Working at All!
    int final_Value = 0;
    for (int KeyToMatrix_1 = 1, actualI = 0; actualI < Dim_quadratic / 2; actualI++)
    {
        for (int j = actualI; j < Dim_quadratic - actualI; j++)
            SpiralMatrix[actualI, j] = KeyToMatrix_1++;
        for (int j = actualI; j < Dim_quadratic - actualI; j++)
            SpiralMatrix[Dim_quadratic - actualI - 1, j] = KeyToMatrix_1++;
        for (int i = actualI + 2; i < Dim_quadratic - actualI - 1; i++)
            SpiralMatrix[i, actualI] = KeyToMatrix_1++;
        for (int i = actualI + 1; i < Dim_quadratic - actualI - 1; i++)
            SpiralMatrix[i, Dim_quadratic - actualI - 1] = KeyToMatrix_1++;
        //KeyToMatrix_1 = 1 - KeyToMatrix_1;
        SpiralMatrix[actualI + 1, actualI] = KeyToMatrix_1++;
        final_Value = KeyToMatrix_1;
    }
    if (Dim_quadratic % 2 != 0 && SpiralMatrix[0, 0] == 1)
        SpiralMatrix[Dim_quadratic / 2, Dim_quadratic / 2] = final_Value;
    **/
    return SpiralMatrix;
}

//int[,] uLeMatrix = SpiralMatrix(4);
/*int[,] uLeMatrix = SpiralMatrixSecondAttempt(4);
PrintMatrix(uLeMatrix);
/**SpiralMatrixSecondAttempt OUTPUT 1:
1 2 3 4 
12 13 14 5
11 16 15 6
10 9 8 7
SpiralMatrixSecondAttempt OUTPUT 2:
1 2 3 4 5 6 7 8 
28 29 30 31 32 33 34 9
27 48 49 50 51 52 35 10
26 47 60 61 62 53 36 11
25 46 59 64 63 54 37 12
24 45 58 57 56 55 38 13
23 44 43 42 41 40 39 14
22 21 20 19 18 17 16 15
SpiralMatrix Failure Output 1:
1 2 3 4
0 0 0 5
0 20 21 6
10 15 14 13
**/

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
                PascalMatrix[i, PascalMatrix.GetLength(1) / 2 - i] = PascalMatrix[i - 1, PascalMatrix.GetLength(1) / 2 - i - 1] + PascalMatrix[i - 1, PascalMatrix.GetLength(1) / 2 + i - 1];
                PascalMatrix[i, PascalMatrix.GetLength(1) / 2 + i] = PascalMatrix[i - 1, PascalMatrix.GetLength(1) / 2 - i - 1] + PascalMatrix[i - 1, PascalMatrix.GetLength(1) / 2 + i - 1];
            }
        }
    }
    return PascalMatrix;
}

/*uint[,] Pascal2DArray = PascalOutTriangleI(N);
PrintMatrixInts(Pascal2DArray);
/** OUTSIDE OF BOUNDS OF THE ARRAY **/