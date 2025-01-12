// https://leetcode.com/problems/sequential-digits/description/

using System.Text;

var sol = new Solution();

sol.SequentialDigits(1000, 13000);


public class Solution
{
    public IList<int> SequentialDigits(int low, int high)
    {
        List<int> result = [];

        for (int seed = 1; seed <= 9; seed++)
        {
            int number = seed;
            int i = seed + 1;

            while (i <= 9)
            {
                number = number * 10 + i;
                i++;

                if (number >= low && number <= high)
                {
                    result.Add(number);
                }
            }
        }

        return result.OrderBy(x => x).ToList();
    }
}