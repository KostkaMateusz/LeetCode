//https://leetcode.com/problems/pascals-triangle/description/

var sol = new Solution();

sol.Generate(4);

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> pascalTriangle = [];
        
        for(int rowSize = 1; rowSize <= numRows; rowSize++)
        {
            List<int> row = [];

            for(int index = 0; index < rowSize; index++)
            {
                if(index==0 || index== rowSize - 1)
                {
                    row.Add(1);
                }
                else
                {                   
                    row.Add(pascalTriangle[rowSize - 2][index - 1] + pascalTriangle[rowSize - 2][index]);
                }
            }
            pascalTriangle.Add(row);        
        }
        return pascalTriangle;
    }
}