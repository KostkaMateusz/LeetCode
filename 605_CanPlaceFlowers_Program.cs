// https://leetcode.com/problems/can-place-flowers/

var sol = new Solution();

sol.CanPlaceFlowers([1, 0, 0, 0, 1], n: 2);

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        Queue<int> queue = [];

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (n == 0)
                return true;

            var prevSpot = i - 1 < 0 ? 0 : flowerbed[i - 1];
            var nextSpot = i + 1 >= flowerbed.Length ? 0 : flowerbed[i + 1];

            if (prevSpot == 0 && flowerbed[i] == 0 && nextSpot == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n == 0;
    }
}
