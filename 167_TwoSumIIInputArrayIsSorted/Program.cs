//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

var sol = new Solution();

sol.TwoSum(numbers: [2, 7, 11, 15], target: 9);
sol.TwoSum(numbers: [2, 3, 4], target: 6);
sol.TwoSum(numbers: [-1, 0], target: -1);
sol.TwoSum(numbers: [0, 0, 3, 4], target: 0);


public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int currentSum = 0;
        int leftPointer = 0;
        int rightPointer = numbers.Length - 1;

        do
        {
            currentSum = numbers[leftPointer] + numbers[rightPointer];         
            if (currentSum < target)
                leftPointer++;
            else if (currentSum > target)
                rightPointer--;
        }
        while (currentSum != target);

        return [leftPointer + 1, rightPointer + 1];
    }
}