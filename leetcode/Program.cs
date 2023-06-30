int fromBase = 10;
int toBase = 2;
int num1 = 3;
string result = Convert.ToString(Convert.ToInt32(num1, fromBase), toBase);

/* using System.Numerics;

int[] GetRandomArray(int sa)
{
    int[] array = new int[sa];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(int.MinValue, int.MaxValue);
    }
    return array;
}

int[] nums = new int[10];
nums = GetRandomArray(10);
Console.WriteLine(Solution.CountBeautifulPairs(nums));
public class Solution
{
    public int CountBeautifulPairs(int[] nums)
    {
        int[] array = nums;
        int result = 0;
        for (int i = 0; i < array.Length; ++i)
            for (int j = i+1; j < array.Length; ++j)
            {
                if (BigInteger.GreatestCommonDivisor(array[i], array[j]) == 1)
                    result++;
            }
        return result;
    }
} */


/* public class Solution
{
    public int CountBeautifulPairs(int[] nums)
    {
        int N = nums.Length;

        var A = nums;
        var B = nums;

        var X = new bool[N];
        var Y = new bool[N];

        var count = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (!Y[j])
                    if (int.Parse(A[i]) == int.Parse(B[j]))
                    {
                        X[i] = Y[j] = true;
                        count++;
                        break;
                    }
            }
        }

        foreach (var x in X)
        {
            if (!x)
                foreach (var y in Y)
                {
                    if (!y)
                    { count++; Console.WriteLine(count); return; }
                }
        }

        count--;
        return count;
    }
} */