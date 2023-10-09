const int rows = 3;
const int columns = 4;

int min(int m1, int m2)
{
    if (m1 < m2)
    return m1;
    else
    return m2;
}

int max(int m1, int m2)
{
    if (m1 > m2)
    return m1;
    else
    return m2;
}

/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

int[,] GetSumMatrix(int rows, int columns)//GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1);++j)
        {
            matrix[i,j] = i+j;//Random.Shared.Next(min(i*j,j),max(i,i*j));
        }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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


/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/
int[,] GetSumMatrix48(int rows, int columns)//GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1);++j)
        {
            matrix[i,j] = i+j;//Random.Shared.Next(min(i*j,j),max(i,i*j));
        }
        return matrix;
}
void GetSumMatrix49(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); ++i)
        for (int j = 0; j < mat.GetLength(1);++j)        
            if (i % 2 == 0 && j % 2 == 0)
                mat[i,j] = mat[i,j]*mat[i,j];
}

/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
int GetSumMatrix51(int[,] mat)
{
    int sum = 0;
    for (int i = 0; i < min(mat.GetLength(0),mat.GetLength(1)); ++i)  //for (int i = 0; i < matrix.GetLength(0) && matrix.GetLength(1); i++)
        sum += mat[i,i];
    return sum;
}

int [,] myMatrix = GetSumMatrix48(rows, columns);
//int [,] myMatrix = GetRandomMatrix(rows, columns);
PrintMatrix(myMatrix);
GetSumMatrix49(myMatrix);
PrintMatrix(myMatrix);
PrintMatrix(GetSumMatrix(rows,columns));
Console.WriteLine($"GetSumMatrix51 = {GetSumMatrix51(myMatrix)}");

decimal a = Convert.ToSingle();