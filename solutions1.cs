using System.Text.RegularExpressions;

public class solutions1
{
    public static void MoveZeroes(int[] nums)
    {
        var aa = new List<int>();
        var bb = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                aa.Add(nums[i]);
            else
                bb.Add(nums[i]);
        }
        bb.AddRange(aa);
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = bb[i];
        }
    }

    public string MergeAlternately(string word1, string word2)
    {
        var length = word1.Length;
        if (word2.Length > length)
            length = word2.Length;
        char[] word1a = word1.ToCharArray();
        char[] word2a = word2.ToCharArray();
        string res = "";
        for (int i = 0; i < length; i++)
        {
            if (word1.Length > i)
                res += word1a[i];
            if (word2.Length > i)
                res += word2a[i];
        }

        return res;
    }

    public string GcdOfStrings(string str1, string str2)
    {
        var all = new int[str2.Length];
        for (int i = 0; i < str2.Length; i++)
        {
            all[i] = Regex.Matches(str1, str2.Substring(0, str2.Length - i).ToUpper()).Count();
        }
        var max = all.Max();
        for (int i = str2.Length - 1; i >= 0; i--)
        {
            if (max == all[i])
            {
                return str2.Substring(0, i + 1);
            }
        }
        return str2;
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var res = new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++)
        {
            var temp = candies[i] + extraCandies;
            if (candies.Max() == temp || candies.Max() < temp)
                res[i] = true;
            else
                res[i] = false;
        }

        return [.. res];
    }

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        bool canPlant = false;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1)
            {
                canPlant = false;
                continue;
            }
            else if (canPlant && n > 0)
            {
                if (i != flowerbed.Length && flowerbed[i + 1] == 1)
                    continue;
                n--;
                canPlant = false;
            }
            else if (flowerbed[i] == 0)
                canPlant = true;
        }

        return n != 0 ? false : true;
    }


    public static int ss(int a, int b) => a > b ? a - b : b - a;
    public static int aaa(int a, int b) => a < b ? a : b;
    public static int MaxArea(int[] height)
    {
        if (height.Length > 100001 || height.Length < 2) return 0;
        var max = 0;
        int h = 0;
        for (int i = 0, j = height.Length - 1; i < j; i++)
        {
            if (height[j] > height[i])
            {
                h = height[i];
                i++;
            }
            else
            {
                h = height[j];
                j--;
            }
            var area = (j - i) * h;
            if (area > max)
                max = area;
        }

        return max;
    }

    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
            return false;

        int i = 0, j = 0;
        for (; j < t.Length; j++)
        {
            if (i != s.Length && t[j] == s[i])
            {
                i++;
            }
        }

        return s.Length == i;
    }


}
