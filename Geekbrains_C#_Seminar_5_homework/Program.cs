/**Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2**/

int[] GetRandomArray(int sa)
{
    int[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 999);
    }
    return array;
}

int NumberOfEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i <arr.Length; ++i)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}

int amount = 100;
int[] array = new int[100];
array = GetRandomArray(amount);
Console.WriteLine(NumberOfEven(array));

/**Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0**/

int[] GetRandomArray(int sa)
{
    int[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(int.MinValue, int.MaxValue);
    }
    return array;
}

int SumOfOddPositions(int[] inputtingArray)
{
    int sum = 0;
    for (int i = 0; i < inputtingArray.Length; ++i)
    {
        if (i % 2 == 1)
            sum += inputtingArray[i];
    }
}
int size_array = 10;
int[] array = GetRandomArray(size_array);
Console.WriteLine(SumOfOddPositions(array));

/**Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76**/

int Difference(double[] array)
{
    int max = array[0];
    int min = array[0];
    if (array.Length == 1)
        return 0;
    for (int i = 1; i<array.Length;++i)
    {
        if (max < array[i])
            max = array[i];
        if (min < array[i])
            min = array[i];
    }
    return max - min;
}

double[] GetRandomArray(int sa)
{
    double[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.NextDouble();
    }
    return array;
}
int arr_size = 10;
double[] arr = GetRandomArray(arr_size);
Console.WriteLine(Difference(arr));

