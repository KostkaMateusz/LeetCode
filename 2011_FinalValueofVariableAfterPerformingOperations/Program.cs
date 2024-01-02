//https://leetcode.com/problems/final-value-of-variable-after-performing-operations/description/

var sol = new Solution().FinalValueAfterOperations(new string[] { "--X", "X++", "X++" });

Console.WriteLine(sol);

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int finalValue = 0;
        foreach (string operation in operations)
        {
            switch (operation)
            {
                case "X++":
                    finalValue++;
                    break;
                case "++X":
                    finalValue++;
                    break;
                case "--X":
                    finalValue--;
                    break;
                case "X--":
                    finalValue--;
                    break;
            }

        }
        return finalValue;
    }
}