// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        if (nums.Length == 1)
            return 1;

        int upPointer = 1;
        int lowPointer = 0;


        while (upPointer < nums.Length)
        {
            if (nums[upPointer] == nums[lowPointer])
            {

                if (upPointer != lowPointer)
                    nums[upPointer] = -200;

                upPointer++;
            }
            else if (nums[upPointer] != nums[lowPointer])
            {
                lowPointer++;

                if (nums[lowPointer] == -200)
                {
                    nums[lowPointer] = nums[upPointer];
                }



            }
        }

        return lowPointer + 1;
    }
}
