// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/**

/**OUTPUT
**/

/**Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] **/

/**
int[] GetRandomArray(int sa)
{
    int[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(int.MinValue, int.MaxValue);
    }
    return array;
}

int[] Replace_Ints(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = -array[i];
    }
    return array;
}

int[] ary = GetRandomArray(5);
Console.WriteLine(string.Join(", ", ary));
ary = Replace_Ints(ary);
//Console.WriteLine("${string.Join(" ", ary)}");
Console.WriteLine(string.Join(", ", ary));
/**OUTPUT
887074858, -2019815026, -380054822, 2128888425, 1767541570
-887074858, 2019815026, 380054822, -2128888425, -1767541570
**/

/**Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> нет**/

/**
int[] GetArray(int sa)
{
    int[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


bool array_exists(int[] array, int sa, int t)
{
    array = GetArray(sa);
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] == t)
            return true;
    }
    return false;
}
int sa = 5;
int[] our = new int[sa];
Console.WriteLine("If this value actually exists: input a value to search");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(array_exists(our, sa, a));
/**OUTPUT
If this value actually exists: input a value to search
7
Введите 0 элемент: 
1
Введите 1 элемент: 
9
Введите 2 элемент: 
0
Введите 3 элемент: 
2
Введите 4 элемент: 
7
True
**/

/**
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
**/

/**
int[] array_multiplication(int[] my_array, int len_of_new)
{
    int[] new_arr;
    if (my_array.Length % 2 == 0)
        new_arr = new int[len_of_new];
    else
        new_arr = new int[len_of_new+1];
    for (int i = 0; i < len_of_new; ++i)
    {
            new_arr[i] = my_array[i] * my_array[my_array.Length-i-1];
    }
    if (my_array.Length % 2 == 1)
        new_arr[len_of_new] = my_array[len_of_new];
    return new_arr;
}
int t = 8;
int[] arrui = GetArray(t);
int len_of_new = arrui.Length/2;
int[] iarray = array_multiplication(arrui, len_of_new);
Console.WriteLine(string.Join(", ", iarray));
/** OUTPUT
Введите 0 элемент: 
1000
Введите 1 элемент: 
100
Введите 2 элемент: 
10
Введите 3 элемент: 
1
Введите 4 элемент: 
10
Введите 5 элемент: 
100
Введите 6 элемент: 
1000
Введите 7 элемент: 
10000
10000000, 100000, 1000, 10**/

//int lennewarr = Arr.Length / 2 + (Arr.Length & 0x01);