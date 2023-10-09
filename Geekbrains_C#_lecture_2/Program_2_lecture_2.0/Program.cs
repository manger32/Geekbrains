/* Функция, нахождение максимума среди трёх элементов.
int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} */

/* Подход с массивом, небольшое число элементов.
//              0  1   2   3    4   5   6   7   8
int[] array = {11, 2, 33, 24, 151, 16, 72, 18, 91};
array[0] = 12;
Console.WriteLine(array[4]);

int maxr = max(max(array[0],array[1],array[2]),
               max(array[3],array[4],array[5]),
               max(array[6],array[7],array[8]));

Console.WriteLine(maxr);*/

/* Не основанные на массивах походы к решению задачи. 
int aa = 8, ab = 0, ac = 19, ba = 10, bb = 29, bc = 1022, ca = 13, cb = 18, cc = 20;*/

/* Подход с применением функции от результатов выполнения той же функции. 
int maxr = max(max(aa, ab, ac), max(ba, bb, bc), max(ca, cb, cc));
Console.WriteLine(maxr);*/

/* Подход с применением функций.
int max1 = max(aa, ab, ac);
int max2 = max(ba, bb, bc);
int max3 = max(ca, cb, cc);
int maxr = max(max1, max2, max3);
Console.WriteLine(maxr);
*/

/* Стихийный подход 60-х годов.
int max = aa;
if (ab > max) max = ab;
if (ac > max) max = ac;

if (ba > max) max = ba;
if (bb > max) max = bb;
if (bc > max) max = bc;

if (ca > max) max = ca;
if (cb > max) max = cb;
if (cc > max) max = cc;

Console.WriteLine(max);*/