int a;
int b;
Console.WriteLine("Input integer number a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer number b:");
b = Convert.ToInt32(Console.ReadLine());
int c = a + b;
/*
double numberA = new Random().Next(1,10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
double numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int c = numberA + numberB;
*/
Console.WriteLine("Integer numbers' sum is: " + c);