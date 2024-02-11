// https://leetcode.com/problems/can-place-flowers/description/

var sol = new Solution();

var res = sol.CanPlaceFlowers([1, 0, 0, 0, 1], 1);
Console.WriteLine(res);

res = sol.CanPlaceFlowers([1, 0, 0, 0, 1], 2);
Console.WriteLine(res);


public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (var i = 0; i < flowerbed.Length; i++)
        {
            if(n == 0) 
                return true;

            var prevSpot = i - 1 < 0 ? 0 : flowerbed[i - 1];

            var nextSpot = i + 1 >= flowerbed.Length ? 0 : flowerbed[i + 1];

            if (prevSpot == 0 && flowerbed[i] == 0 && nextSpot == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }
        return n==0;
    }
}