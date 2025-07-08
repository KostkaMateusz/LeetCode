// https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions/

using System.Text.Json;

var sol = new Solution();

var solution = sol.FindMatrix([1, 3, 4, 1, 2, 3, 1]);

Console.WriteLine(JsonSerializer.Serialize(solution));

public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        IList<HashSet<int>> matrix = new List<HashSet<int>>();

        matrix.Add(new HashSet<int>());

        foreach (var num in nums)
        {
            for (var index = 0; index < matrix.Count; index++)
            {
                var row = matrix[index];
                if (!row.Contains(num))
                {
                    row.Add(num);
                    break;
                }

                if (index == matrix.Count - 1)
                {
                    var set = new HashSet<int> { num };
                    matrix.Add(set);
                    break;
                }
            }
        }

        IList<IList<int>> matrixOutput = new List<IList<int>>();

        for (int i = 0; i < matrix.Count; i++)
        {
            matrixOutput.Add(matrix[i].ToList());
        }

        return matrixOutput;
    }
}