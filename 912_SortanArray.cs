// https://leetcode.com/problems/sort-an-array/

var sol = new Solution();

sol.SortArray([9, 8, 7, 6, 5]);


public class Solution
{
    public int[] SortArray(int[] nums)
    {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private static void MergeSort(int[] nums, int l, int r)
    {
        if (l >= r)
            return;

        int m = (l + r) / 2;
        MergeSort(nums, l, m);
        MergeSort(nums, m + 1, r);
        Merge(nums, l, m, r);
    }

    private static void Merge(int[] nums, int l, int m, int r)
    {
        List<int> temp = [];
        int i = l;
        int j = m + 1;

        while (i <= m && j <= r)
        {
            if (nums[i] <= nums[j])
            {
                temp.Add(nums[i]);
                i++;
            }
            else
            {
                temp.Add(nums[j]);
                j++;
            }
        }

        while (i <= m)
        {
            temp.Add(nums[i]);
            i++;
        }

        while (j <= r)
        {
            temp.Add(nums[j]);
            j++;
        }

        PrintList(temp);
        for (i = l; i <= r; i++)
        {
            nums[i] = temp[i - l];
        }
    }

    private static void PrintList(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number);
            Console.Write(',');
        }

        Console.WriteLine();
    }
}
