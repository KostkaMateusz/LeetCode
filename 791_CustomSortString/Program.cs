// https://leetcode.com/problems/custom-sort-string/description/


public class Solution
{
    public string CustomSortString(string order, string s)
    {
        Dictionary<char, int> orderDict = [];

        for (int i = 0; i < order.Length; i++)
        {
            orderDict.Add(order[i], i);
        }


        var sArray = s.ToArray();

        Array.Sort(sArray, (a, b) =>
        {
            var weightA = orderDict.GetValueOrDefault(a);
            var weightB = orderDict.GetValueOrDefault(b);


            if (weightA > weightB)
                return 1;
            else if (weightA < weightB)
                return -1;
            else
                return 0;

        });

        return string.Join("", sArray);
    }
}