
var sol = new Solution();

var result=sol.SumOddLengthSubarrays([1, 4, 2, 5, 3]);

Console.WriteLine(result);


public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        var windowSize = 1;
        var rollingSum = 0;

        while (windowSize <= arr.Length)
        {
            for(var startPosition = 0; startPosition <= arr.Length; startPosition++)
            {
                var endPosition = startPosition + windowSize;

                if (endPosition > arr.Length)
                {
                    break;
                }

                for (var slider = startPosition; slider < endPosition; slider++)
                {
                    rollingSum += arr[slider];                   
                }                
            }            

            windowSize += 2;
        }
        return rollingSum;
    }
}