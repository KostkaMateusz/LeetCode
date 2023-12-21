

var sol = new OrderedStream(5);

IList<string> output;

output = sol.Insert(3, "ccccc");
output = sol.Insert(1, "aaaaa");
output = sol.Insert(2, "bbbbb");
output = sol.Insert(5, "eeeee");
output = sol.Insert(4, "ddddd");




public class OrderedStream
{
    private string[] stream;
    private int pointer = 0;

    public OrderedStream(int n)
    {
        this.stream = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        stream[idKey-1]=value;

        var outputChunk=new List<string>();

        while (pointer < stream.Length && stream[pointer] is not null)
        {
            outputChunk.Add(stream[pointer]);
            pointer++;
        }

        return outputChunk;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */