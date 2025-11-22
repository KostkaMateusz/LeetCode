// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        // where are they
        List<int> ballsLocation = [];

        for (int i = 0; i < boxes.Length; i++)
        {
            char b = boxes[i];
            if (b == '1')
            {
                ballsLocation.Add(i);
            }
        }

        int[] moves = new int[boxes.Length];


        for (int i = 0; i < boxes.Length; i++)
        {


            foreach (int loc in ballsLocation)
            {
                if (loc == i)
                    continue;

                moves[i] += Math.Abs(loc - i);

            }


        }
        return moves;

    }
}
