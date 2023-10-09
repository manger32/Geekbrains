/**Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Введите трёхзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 1000 && numberA > 99)
    Console.WriteLine(numberA/10%10);
else
    Console.WriteLine("Введено не трёхзначное число");

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

#13.1 Справа
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 99)
    Console.WriteLine(numberA%1000/100);
else
    Console.WriteLine("третьей цифры нет");

#13.2 Слева
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 0;
bool Flag = true;
int numberofdigitsrequired = 3;
int numberofdigits = numberA;
int index = 0;
string s = $"В числе меньше {numberofdigitsrequired} цифр";
while (numberofdigits != 0)
{
    numberofdigits = numberofdigits / 10;
    index++;
}
if (index == numberofdigitsrequired)
{
    Console.WriteLine(numberA%10);
    Environment.Exit(0);
}
else if (index < numberofdigitsrequired)
{
    Console.WriteLine(s);
    Environment.Exit(0);
}
while (numberA != 0)
{
    numberA = numberA / 10;
    ++i;
    if (i >= index - numberofdigitsrequired)
    {
        Console.WriteLine(numberA % 10);
        Flag = false;
        break;
    }
}
if (Flag)
    Console.WriteLine(s);

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0 && numberA < 7)
    if (numberA == 6 && numberA == 7)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Будний")
else
    Console.WriteLine("это не день недели");

**/


