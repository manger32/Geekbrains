string lorean = "Markdown, zimbabwe. Markup, Bangladesh.";

string Replace(string text, char oldValue, char newValue) 
{ 
    string result = String.Empty;
    int length = text.Length; 
    for (int i = 0; i < length; i++) 
    { 
        if (text[i] == oldValue) 
            result += $"{newValue}"; 
        else 
            result += $"{text[i]}"; 
    } 
    return result;
} 
string newText = Replace(lorean, ' ', '|'); 
Console.WriteLine(newText);
newText = Replace(lorean,'M','m');
Console.WriteLine(newText);

/*2*/
int min(int m1, int m2)
{
    if (m1 < m2)
    return m1;
    else
    return m2;
}

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] collection)
{
    int count = collection.Length;
    for (int i = 0; i < count; ++i)
    {
        Console.Write($"{collection[i]}\t");
    }
    Console.WriteLine();
}

int[] SwapMins(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; ++i)
    {
        int localmin = array[i];
        int localminindex = i;
        for (int j = i+1; j < count; ++j)
        if (array[localminindex] > array[j])
        {
            localmin = array[j];
            localminindex = j;
        }
        int temp = array[i];
        array[i] = array[localminindex];
        array[localminindex] = temp;
    }
    return array;
}
PrintArray(arr);
SwapMins(arr);
Console.WriteLine(String.Join("\t", arr));