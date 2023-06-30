/**Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.**/

uint a=5,b=30,c=45;
bool CheckIfTriangleExists(uint a, uint b, uint c)
{
    if (a<0 || b<0||c<0)
    {
        Console.WriteLine("Are you mad?");
    }
    else if (a+b > c && a+c > b && b+c > a)
    {
        Console.WriteLine("Such a triangle exists");
        return true;
    }
    else
    {
        Console.WriteLine("Such a triangle does not exist");
        return false;
    }
}

/**Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10**/
//VAR_1
/**int[] arr = new int[32];
void bintype(int a)
{
    for (int i = 0; i < 32; i++)
    {
        arr[i] = (int)(a>>i &0x01);
    }
}
//VAR_2
bintype(91);
for (int i = 0; i < 32; i++)
{
    Console.Write(arr[i]);
}

Console.WriteLine("введите число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a;
int count=0;
    while(b!=0){
        count++;
        b=b/2;
    }
int[] c=new int[count];
    while(a!=0){
        for(int i=0;i<c.Length;i++){
            c[i]=a%2;
            a=a/2;
        }
    }
string s="";
for (int i = c.Length-1; i >= 0; --i){
s+=c[i].ToString();}
Console.WriteLine(s);**/