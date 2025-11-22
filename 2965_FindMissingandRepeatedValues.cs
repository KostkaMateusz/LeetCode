// https://leetcode.com/problems/find-missing-and-repeated-values/

var sol = new Solution();

sol.FindMissingAndRepeatedValues(

    [[1, 3], [2, 2]]
);


public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        bool[] seenNumbers = new bool[grid.Length * grid.Length + 1];

        int[] answer = new int[2];

        foreach (var row in grid)
        {
            foreach (var num in row)
            {
                if (seenNumbers[num])
                {
                    answer[0] = num; // Found the repeated number
                }
                else
                {
                    seenNumbers[num] = true;
                }
            }
        }


        for (int i = 1; i <= seenNumbers.Length; i++)
        {
            if (!seenNumbers[i])
            {
                answer[1] = i;
                break;
            }
        }

        return answer;
    }
}



public class Solution1
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        HashSet<int> allNumbers = new(Enumerable.Range(1, grid.Length * grid.Length));

        int[] answer = new int[2];

        foreach (var row in grid)
        {
            foreach (var num in row)
            {
                if (allNumbers.Contains(num))
                {
                    allNumbers.Remove(num);
                }
                else
                {
                    answer[0] = num; // Found the repeated number
                }
            }
        }

        answer[1] = allNumbers.First(); // The remaining number is the missing one

        return answer;
    }
}
