











public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {        
        var outputList=new List<int>(nums.Length);

        for(int i=0;i<nums.Length; i++)        
            outputList.Insert(index[i], nums[i]);        

        return outputList.ToArray();
    }
}