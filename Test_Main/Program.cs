int N;

List<String> FindAllOfLengthLessThan3Strings(int N)
{
    String[] arrayStr = new String[N];
    List<String> resultingList = new List<String>();
    int EmptyStringAmount = 0;
    for (int i = 0; i < N; ++i)
    {
        String currentString = Console.ReadLine();
        if (String.IsNullOrEmpty(currentString))
        {
            resultingList.Add("");
            EmptyStringAmount++;
        }
        else 
            arrayStr[i-EmptyStringAmount] = currentString;
    }
    for (int i = 0; i < arrayStr.Length; ++i)
    {
        if (arrayStr[i].Length < 4)
            resultingList.Add(arrayStr[i]);
    }
    return resultingList;
}


Console.WriteLine("Input string amount");
N = Convert.ToInt32(Console.ReadLine());
List<String> resList = FindAllOfLengthLessThan3Strings(N);
Console.WriteLine(resList.Aggregate((a, b) => String.Format("{0}, {1}", a, b)));