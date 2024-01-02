//https://leetcode.com/problems/shuffle-the-array/description/
var sol = new Solution();

var answer=sol.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 },3);

Console.WriteLine(answer);


public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int insertingPointer = 0;
        int pointerA = 0;
        int pointerB = n;

        int[] shuffledArray= new int[nums.Length];

        while (pointerB < nums.Length) 
        {
            shuffledArray[insertingPointer] = nums[pointerA];
            shuffledArray[insertingPointer+1] = nums[pointerB];
            insertingPointer+=2;
            pointerA++;
            pointerB++;
        }

        return shuffledArray;
    }
}