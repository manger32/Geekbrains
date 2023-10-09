int[] array = {1,12,31,4,15,16,17,18,15};

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  // Без break - последнее вхождение.
        }
        index++;
    }
    return position;
}

void FillInt(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintInt(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] arraySecond = new int[10];
FillInt(arraySecond);
PrintInt(arraySecond);
Console.WriteLine();

int pos = IndexOf(arraySecond, 5);
Console.WriteLine(pos);