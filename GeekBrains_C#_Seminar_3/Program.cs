/**Инструкция: раскомментируйте строку (символы /** перед программой) для запуска программы.**/
/**[--------------------------------------------------------------------------------------------------]
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
**/

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool fl = true;

int Number_of_Digits(int number)
{
    int t = 0;
    while (number != 0)
    {
        t++;
        number = number / 10;
    }
    return t;
}

bool Palindrome_Check(int number)
{
    int t = 0, len = Number_of_Digits(number);
    bool result = true;
    while (t != len / 2)
    {
        int begin = number / (int)Math.Pow(10, len - t - 1) % 10, end = number / (int)Math.Pow(10,t) % 10;
        //Console.WriteLine($"digit {t}, {begin}, {end}"); -- Tracing
        if (begin != end)
        {
            result = false;
            break;
        }
        t++;
    }
    return result;
}
int r = GetObj("Provide an integer ten to infinity");
fl = Palindrome_Check(r);
Console.WriteLine($"Checked if palindrome: {fl}, with digit number of {Number_of_Digits(r)}");
/**OUTPUT:
19000091
digit 0, 1, 1
digit 1, 9, 9
digit 2, 0, 0
digit 3, 0, 0
Checked if palindrome: True, with digit number of 8
**/

/**[--------------------------------------------------------------------------------------------------]
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
**/

/**
int GetCoord(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double GetObj(int A1, int A2, int A3, int B1, int B2, int B3)
{
    A1 = GetCoord("Input Point 1.x coordinates");
    A2 = GetCoord("Input Point 1.y coordinates");
    A3 = GetCoord("Input Point 1.z coordinates");
    B1 = GetCoord("Input Point 2.x coordinates");
    B2 = GetCoord("Input Point 2.y coordinates");
    B3 = GetCoord("Input Point 2.z coordinates");
    Point A = new Point(A1,A2,A3);
    Point B = new Point(B1,B2,B3);
    return A.distance(B);
}

int r1 = 0, r2 = 0, r3 = 0, q1 = 0, q2 = 0, q3 = 0;
double dist = GetObj(r1,r2,r3,q1,q2,q3);
Console.WriteLine(dist);
public class Point
{
    int a,b,c;
    public Point(int x, int y, int z)
    {
        a = x;
        b = y;
        c = z;
    }
    public double distance(Point Q3)
    {
        return Math.Cbrt(Math.Pow(Q3.a - a, 3) + Math.Pow(Q3.b - b, 3) + Math.Pow(Q3.c - c, 3));
    }
};
/**OUTPUT
Input Point 1.x coordinates
5
Input Point 1.y coordinates
7
Input Point 1.z coordinates
2
Input Point 2.x coordinates
0
Input Point 2.y coordinates
-1
Input Point 2.z coordinates
8
-7,494811225859051
**/


/**[--------------------------------------------------------------------------------------------------]
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125**/

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Print_Cube_Table(int N)
{
    var i = 1;
    int q = 4; //Power you need
    int outing = 1;
    if (N == 1)
        Console.WriteLine(N);
    else if (N == -1)
        Console.WriteLine(N);
    else if (N > 1)
    {
        while (i!=q)
        {
            outing *= N;
            i++;
        }
        Console.WriteLine(outing);
        Print_Cube_Table(N-1);
    }
    else if (N <= 0)
    {
        while (i!=q)
        {
            outing *= N;
            i++;
        }
        Console.WriteLine(outing);
        Print_Cube_Table(N+1);
    }
}

int N = GetObj("Input an integer number N");
Print_Cube_Table(N);
/**OUTPUT
Input an integer number N
9
729
512
343
216
125
64
27
8
1
Input an integer number N
-80 
-512000
-493039
-474552
-456533
-438976
-421875
-405224
-389017
-373248
-357911
-343000
-328509
-314432
-300763
-287496
-274625
-262144
-250047
-238328
-226981
-216000
-205379
-195112
-185193
-175616
-166375
-157464
-148877
-140608
-132651
-125000
-117649
-110592
-103823
-97336
-91125
-85184
-79507
-74088
-68921
-64000
-59319
-54872
-50653
-46656
-42875
-39304
-35937
-32768
-29791
-27000
-24389
-21952
-19683
-17576
-15625
-13824
-12167
-10648
-9261
-8000
-6859
-5832
-4913
-4096
-3375
-2744
-2197
-1728
-1331
-1000
-729
-512
-343
-216
-125
-64
-27
-8
-1
**/

//[--------------------------------------------------------------------------------------------------]
//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

/**int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int A)
{
    int sum = 0;
    for (int i=1;i<=A;++i)
    {
        sum = sum+i;
    }
    return sum;
}
string msg = "Input Integer Numbers";
int q = GetObj(msg);
int numbers = SumFrom1ToA(q);
Console.WriteLine(numbers);
/**OUTPUT
Input Integer Numbers
19
190
Input Integer Numbers
28
406
**/

//[--------------------------------------------------------------------------------------------------]
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int BoolLING(int a)
{
    int qq = 0;
    while (a != 0){
        a=a/10;
        qq++;
    }
    return qq;
}

int val = GetObj("Input Integer");
int tr = BoolLING(val);
Console.WriteLine(tr);
/**OUTPUT
Input Integer
678
3
**/

/**
[--------------------------------------------------------------------------------------------------]
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
**/

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GitOper(int ch)
{
    int res = 1;
    while (ch > 1)
    {
        res = res*ch;
        //Console.WriteLine(res); -- Tracing
        ch--;
    }
    return res;
}

int qval=GetObj("Input Integer");
Console.WriteLine(GitOper(qval));
/**OUTPUT
Input Integer
5
120
**/

/**
[--------------------------------------------------------------------------------------------------]
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
**/

/**
int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] CountNumberOfElements(int a)
{
    int[] array = new int[a];
    int i = 0;
    while (i<array.Length)
    {
        array[i] = Random.Shared.Next()%2;
        i++;
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.WriteLine(array[i]);
}

int oplecs = GetObj("Get a number:");
int[] arr = CountNumberOfElements(oplecs);
printArray(arr);
/**OUTPUT
Get a number:
3
1
0
1
**/