using System.ComponentModel;

public static class Solution
{
    public static int LargestAltitude(int[] gain)
    {
        var nm = new List<int>();
        nm.Add(0);
        for (int i = 1; i < gain.Length; i++)
        {
            if (gain[i] == 0)
                continue;
            nm.Add(nm[i - 1] + gain[i]);
        }
        return nm.Max();
    }


    public static double FindMaxAverage(int[] nums , int k)
    {
        int i = k;
        double temp, maks=0;
        temp = nums.Take(k).Sum();
        maks = temp / k;
        while (nums.Length > i)
        {
            temp = temp + nums[i] - nums[i-k];
            if (maks < temp/k)
                maks = temp/k;
            i++;
        }
        return maks;
    }
    public static string[] sortStrings(string[] arr)
    {
        return arr.OrderBy(s => s[1]).ToArray();
    }
}

public static class Program
{
    public static void Main()
    {
        string[] input = { "b1", "c2", "x3", "x4", "z0" };
        string[] sortedArray = Solution.sortStrings(input);
        
        Console.WriteLine(string.Join(", ", sortedArray));
    }
}
