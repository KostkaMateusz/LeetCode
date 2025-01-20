// https://leetcode.com/problems/sequential-digits/description/

using System.Text;

var sol = new Solution();

sol.SequentialDigits(1000, 13000);

public class Solution
{
    public IList<int> SequentialDigits(int low, int high)
    {
        IList<int> result = [];

        Queue<int> queue = new([1, 2, 3, 4, 5, 6, 7, 8, 9]);

        while (queue.Count > 0)
        {
            int n=queue.Dequeue();
            if (n > high)
            {
                continue;
            }

            if (n >= low && n <= high)
            {
                result.Add(n);
            }
            
            int lastDigit=n%10;

            if (lastDigit < 9)
            {
                queue.Enqueue(n*10+(lastDigit+1));
            }
        }
        

        return result;
    }
}


public class Solution1
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