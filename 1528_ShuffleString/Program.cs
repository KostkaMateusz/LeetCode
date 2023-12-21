


var sol = new Solution();

sol.RestoreString("codeleet", [4, 5, 6, 7, 0, 2, 1, 3]);




public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        var outputArray = new char[s.Length];

        for(int i = 0; i < indices.Length; i++)        
            outputArray[indices[i]] = s[i];        

        return string.Join("", outputArray);
    }
}