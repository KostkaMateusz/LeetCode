public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var source=new HashSet<string>();
        var destination=new HashSet<string>();

        foreach (var destinationPair in paths)
        {
            source.Add(destinationPair[0]);
            destination.Add(destinationPair[1]);
        }

        return destination.Except(source).First();

    }
}