// https://leetcode.com/problems/ransom-note/

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> rancomDict = new();
        Dictionary<char, int> magazineDict = new();

        foreach (char s in ransomNote)
        {
            if (!rancomDict.TryAdd(s, 1))
            {
                rancomDict[s]++;
            }
        }

        foreach (char s in magazine)
        {
            if (!magazineDict.TryAdd(s, 1))
            {
                magazineDict[s]++;
            }
        }


        foreach (var (key, value) in rancomDict)
        {

            if (!magazineDict.ContainsKey(key) || magazineDict[key] < value)
            {
                return false;
            }
        }

        return true;

    }
}
