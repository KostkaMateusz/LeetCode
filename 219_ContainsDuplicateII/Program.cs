// https://leetcode.com/problems/contains-duplicate-ii/
var sol = new Solution();
bool result;

result=sol.ContainsNearbyDuplicate(nums : [1,2,3,1], k : 3);
Console.WriteLine(result);

result=sol.ContainsNearbyDuplicate(nums : [1,0,1,1], k : 1);
Console.WriteLine(result);

result=sol.ContainsNearbyDuplicate(nums : [1,2,3,1,2,3], k : 2);
Console.WriteLine(result);

public class Solution 
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        int L = 0;
        HashSet<int> window = [];

        for (int R = 0; R < nums.Length; R++)
        {
            if (R - L > k)
            {
                window.Remove(nums[L]);
                L++;
            }
            if(window.Contains(nums[R]))
            {
                return true;
            }
            window.Add(nums[R]);
        }
        return false;
    }
}