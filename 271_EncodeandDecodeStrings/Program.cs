using System.Text.Json;

var sol = new Solution();

var en = sol.Encode(["we", "say", ":", "yes"]);

Console.WriteLine(JsonSerializer.Serialize(en));

var de = sol.Decode(en);

Console.WriteLine(JsonSerializer.Serialize(de));

public class Solution
{
    public string Encode(IList<string> strs)
    {
        string res = "";
        foreach (string s in strs)
        {
            res += s.Length + "#" + s;
        }

        return res;
    }

    public List<string> Decode(string s)
    {
        List<string> res = new();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            //get last number index
            while (s[j] != '#')
            {
                j++;
            }

            //get lengh value
            int length = int.Parse(s.Substring(i, j - i));

            res.Add(s.Substring(j + 1, length));

            i = j + length + 1;
        }

        return res;
    }
}