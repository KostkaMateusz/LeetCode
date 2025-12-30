public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxOnes = -1;
        int currentOnes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentOnes++;
            }
            else
            {
                currentOnes = 0;
            }

            maxOnes = Math.Max(currentOnes, maxOnes);
        }

        return maxOnes;
    }
}