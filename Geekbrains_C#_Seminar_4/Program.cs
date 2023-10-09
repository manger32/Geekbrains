/**Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.**/

int Raise_To_Power(pair Q)
{
    int Power = 1;
    int cnt = 1;
    while (cnt != Q.b)
    {
        Power = Power * Q.a;
        cnt++;
    }
    return Power;
}

pair GetObj(int A, int B, string msg)
{
    Console.WriteLine(msg);
    A = Convert.ToInt32(Console.ReadLine());
    B = Convert.ToInt32(Console.ReadLine());
    return new pair(A,B);
}

public class pair{
    public int a, b;
    public pair(int A, int B)
    {
        a = A;
        b = B;
    }
};


