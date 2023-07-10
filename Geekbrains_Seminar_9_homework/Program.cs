/**
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9
m = 2, n = 3 -> A(m,n) = 29
**/
void PrintOutFromNTo1(int N)
{
    if (N == 0)
    { Console.WriteLine(); return; }
    Console.Write($"{N} ");
    PrintOutFromNTo1(N - 1); // for Reverse: Exchange 2 and 3 strings of this method
}

PrintOutFromNTo1(9);

const int M = 10, N = 19;

int SumFromMToN(int M, int N)
{
    if (M == N) return N;
    int Sum = M;
    return Sum + SumFromMToN(M + 1, N);
}

Console.WriteLine(SumFromMToN(M, N));

int AckermanFunction(int m, int n)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n > 0) && (m == 0))
    {
        return AckermanFunction(1, n - 1);
    }
    else if ((n > 0) && (m > 0))
    {
        return AckermanFunction(AckermanFunction(m - 1, n), n - 1);
    }
    return m + 1;
}

Console.WriteLine(AckermanFunction(1, 3));