// https://leetcode.com/problems/count-vowel-strings-in-ranges/

public class Solution
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        int[] VowelStringsArray = new int[words.Length + 1];
        int rollingSum = 0;
        int index = 1;
        for (int i = 0; i < words.Length; i++, index++)
        {
            string word = words[i];

            if ((word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
            && (word[^1] == 'a' || word[^1] == 'e' || word[^1] == 'i' || word[^1] == 'o' || word[^1] == 'u'))
            {
                rollingSum++;
            }
            VowelStringsArray[index] = rollingSum;

        }

        int[] results = new int[queries.Length];
        int resIndex = 0;

        for (int i = 0; i < queries.Length; i++, resIndex++)
        {
            int[] query = queries[i];

            int sum = VowelStringsArray[query[1] + 1] - VowelStringsArray[query[0]];

            results[resIndex] = sum;

        }


        return results;
    }
}





// This solution works but is not efective as it is calculatiing each word each time
public class Solution1
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        int[] results = new int[queries.Length];
        int resIndex = 0;
        char[] vovwels = ['a', 'e', 'i', 'o', 'u'];
        foreach (int[] query in queries)
        {
            for (int i = query[0]; i <= query[1]; i++)
            {
                string word = words[i];

                if (vovwels.Contains(word[0]) && vovwels.Contains(word[^1]))
                {
                    results[resIndex]++;
                }
            }
            resIndex++;
        }

        return results;
    }
}
