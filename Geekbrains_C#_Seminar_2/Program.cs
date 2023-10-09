// See https://aka.ms/new-console-template for more information
/**int qBit = Random.Shared.Next(100,1000);
Console.WriteLine(qBit);
int qqBit = qBit % 10;
int qqqBit = qBit / 100;
int qqqqBit = qqqBit*10+qqBit;
Console.WriteLine(qqqqBit);

Console.WriteLine($"New File {qBit}, quside {qqBit}, ququSide {qqqBit}");


int input = new Random().Next(100, 999);
    int index = 2;
    
    int m = 1;
    while (index > 1) {
        m *= 10;
        index--;
    }
    int result = (input % m) + (input / (m * 10)) * m;
    
    Console.WriteLine("input "+input+" result:" + result);

int n = 1234567;
int digitCount = (int)Math.Log10(n) + 1;
int q = n/(digitCount-1) + n %10;
Console.WriteLine(q);    **/


/**Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да


Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно**/

/**Console.WriteLine("Введите число a:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB=Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint % numberBint ==0){
    Console.WriteLine("кратное");
}
else{
    Console.WriteLine("не кратное");
}**/

/**Console.WriteLine("Введите число :"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
if(numberAint % 7*23 ==0){
    Console.WriteLine("кратно"); 

}
else{
    Console.WriteLine("не кратно"); 
}**/

/**
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is a Square " + Convert.ToString(a*a == b ? true : false));
git commit -m "Gachi"
git push
**/

Console.WriteLine("Введите число a:"); 
string? numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB = Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint * numberAint == numberBint ){
    Console.WriteLine("да");
}
else if(numberAint  == numberBint*numberBint ){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}

int
while (i == )