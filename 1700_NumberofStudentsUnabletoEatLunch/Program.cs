


using System.Linq;

var sol = new Solution();

sol.CountStudents(students : [1, 1, 0, 0], sandwiches : [0, 1, 0, 1]);


public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var studentsCounter = students.GroupBy(x => x).ToDictionary(x =>  x.Key , x=>x.Count() );
        var numberOfSandwiches= sandwiches.Length;

        foreach(var sand in sandwiches)
        {
            if (studentsCounter.TryGetValue(sand, out int value) && value>0)
            {                
                studentsCounter[sand]--;
                numberOfSandwiches--;                
            }
            else
                return numberOfSandwiches;
        }

        return numberOfSandwiches; 
    }
}