



var sol = new Solution();

sol.DestCity([["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]]);




public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var start=new HashSet<string>();
        
        foreach (var connection in paths)
        {
            start.Add(connection[0]);            
        }        

        
        foreach(var destSet in paths)
        {
            var finishDest = destSet[1];
                        
            if (!start.Contains(finishDest))
            {
                return finishDest;
            }            
        }

        return "";
    }
}