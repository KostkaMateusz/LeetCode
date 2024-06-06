


var sol = new Solution();

sol.GetRow(33);

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0)
            return [1];
        else if (rowIndex == 1)
            return [1,1];

        int[] prevRow= [1, 1];
                
        for (int i = 2; i <= rowIndex; i++)
        {
            var row= new int[i+1];
            row[0] = 1;
            row[^1] = 1;
        
            for(int j = 1; j < row.Length - 1; j++)
            {   
                row[j]= prevRow[j - 1] + prevRow[j];
            }
            prevRow=row;
        }
        return prevRow;
    }
}