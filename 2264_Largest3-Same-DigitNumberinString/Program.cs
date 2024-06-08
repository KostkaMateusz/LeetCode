
var sol = new Solution();


Console.WriteLine(sol.LargestGoodInteger("6777133339"));

public class Solution
{
    public string LargestGoodInteger(string num)
    {
        int max = -1;
        string maxString = "";

        for (var i = 2; i < num.Length; i++)
        {
            if (num[i] == num[i - 1] && num[i] == num[i - 2])
            {
                var numberString = num.Substring(i - 2, 3);

                var convertednumber = int.Parse(numberString);

                if (convertednumber > max)
                {
                    max = convertednumber;
                    maxString = numberString;
                }
            }
        }

        return maxString;
    }
}