// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/

var sol = new Solution();
var re=sol.FindDisappearedNumbers([4,3,2,7,8,2,3,1]);

re=sol.FindDisappearedNumbers([1,1]);


Console.WriteLine();

public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var setNums = new HashSet<int>(nums);
        
        var setRequired= new HashSet<int>();

        for (int i = 1; i <= nums.Length; i++)
            setRequired.Add(i);
        
        return  setRequired.Except(setNums).ToList();
    }
}