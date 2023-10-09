/**Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
3, 5 -> 243 (3⁵)
2, 4 -> 16
**/

/**
int func_new(int A, int B)
{
    int result = 1;
    while (B != 0)
    {
        result *= A;
        B--;
    }
    return result;
}

int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int qDigit = GetObj("Enter Integer");
int qPower = GetObj("Enter Power");
Console.WriteLine(func_new(qDigit, qPower));
/**OUTPUT
Enter Integer
190
Enter Power
7
1388793728
**/

/**Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
**/

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int SumOfDigits(int qNumber)
{
    int sum = 0;
    while(qNumber!=0)
    {
        sum += qNumber %10;
        qNumber /= 10;
    }
    return sum;
}
string ss = "Input an integer!";
int newIntegerNewEraOfCode = GetObj(ss);
Console.WriteLine(SumOfDigits(newIntegerNewEraOfCode));
/**OUTPUT
Input an integer!
12391293
30
**/

/**Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.**/

/**void ArraySet(int[] arr)
{
    for (int i = 1; i <= arr.Length; ++i)
    {
        Console.WriteLine($"Input an array's {i}-th element: ");
        arr[i-1] = Convert.ToInt32(Console.ReadLine());
    }
}
void ArrayPrint(int[] arr)
{
    for (int i = 1; i <= arr.Length; ++i)
        Console.WriteLine(arr[i-1]);
}
int[] arr = new int[8];
ArraySet(arr);
ArrayPrint(arr);
/**OUTPUT
Input an array's 1-th element: 
5
Input an array's 2-th element: 
2
Input an array's 3-th element: 
0
Input an array's 4-th element: 
19
Input an array's 5-th element: 
20
Input an array's 6-th element: 
21
Input an array's 7-th element: 
20
Input an array's 8-th element: 
29
5
2
0
19
20
21
20
29
**/