//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int rows = 5; int columns = 7;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(0, 10); // [0,10)
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
    int[,] MatrixT = new int[columnCount, rowCount];
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
        {
            MatrixT[j, i] = matrix[i, j];
        }
    return MatrixT;
}
Console.WriteLine("Task #50");
int[,] MyMatrixNew = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
Console.WriteLine();
int[,] MatrixT = MatrizenTransponieren(MyMatrix);
PrintMatrixInts(MatrixT);

/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
Элементы [0, 9]*/

int[] GetFrequencyOfElementsInMatrix(int[,] MyTwoDimensionalArray)
{
    int[] FrequencyArray = new int[10]; // [0,1,2,3,4,5,6,7,8,9]
    int rowCount = MyTwoDimensionalArray.GetLength(0);
    int columnCount = MyTwoDimensionalArray.GetLength(1);
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
            FrequencyArray[MyTwoDimensionalArray[i, j]]++;
    return FrequencyArray;
}
Console.WriteLine("Task#57");

int[,] GMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(GMatrix);
int[] GFrequency = GetFrequencyOfElementsInMatrix(GMatrix);
for (int i = 0; i < GFrequency.Length; ++i)
{
    Console.Write($"{i} : {GFrequency[i]} | ");
}
Console.WriteLine();

int u = 9;
int a = (u++)+5;
Console.WriteLine(a);
a = (++u)+5;
Console.WriteLine(a);

/**Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 **/
int[] GetPositionMin(int[,] Matrix)
{
    int iPositionMin = 0;
    int jPositionMin = 0;
    int min = Matrix[0,0];
    for (int i = 0; i < Matrix.GetLength(0); ++i)
        for (int j = 0; j < Matrix.GetLength(1); ++j)
        {
            if (Matrix[i,j] < min)
            {
                min = Matrix[i,j];
                iPositionMin = i;
                jPositionMin = j;
            }
        }
    int[] arrayPair = new int[] {iPositionMin,jPositionMin};
    return arrayPair;
}

int[,] RemoveRespectiveRowAndColumn(int[,] Matrix, int[] ArrayToRemove)
{
    int[,] matrixReduced = new int[Matrix.GetLength(0)-1, Matrix.GetLength(1)-1];
    int iShift = 0;
    int jShift = 0;
    for (int i = 0; i < matrixReduced.GetLength(0); ++i)
    {
        if (i == ArrayToRemove[0])
                iShift++;
        for (int j = 0; j < matrixReduced.GetLength(1); ++j)
        {
            if (j == ArrayToRemove[1])
                jShift++;
            matrixReduced[i,j] = Matrix[i+iShift,j+jShift];
        }
        jShift = 0;
    }
    return matrixReduced;
}
Console.WriteLine("Task #59");
Console.WriteLine();
int[,] Matr = GetRandomArray(rows, columns);
int[] array = GetPositionMin(Matr);
PrintMatrixInts(Matr);
Console.WriteLine();
int[,] MatrReduced = RemoveRespectiveRowAndColumn(Matr, array);
PrintMatrixInts(MatrReduced);


//if (I == arr[0] || I == arr[1]) {continue;}
//newarr[k++, t++] = oldarr[I, j];