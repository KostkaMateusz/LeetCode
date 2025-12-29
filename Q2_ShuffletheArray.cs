
var sol = new Solution();

sol.Shuffle([2, 5, 1, 3, 4, 7], 3);


public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] shuffledArray = new int[nums.Length];

        int insertPointer=0;

        for (int pointerA = 0, pointerB = n; pointerB < nums.Length;  pointerA++,pointerB++)
        {
            shuffledArray[insertPointer] = nums[pointerA];
            shuffledArray[insertPointer+1] = nums[pointerB];

            insertPointer+=2;
        }

        return shuffledArray;

    }
}