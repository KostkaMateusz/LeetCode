// https://leetcode.com/problems/relative-sort-array/description/



public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> order = [];

        for (int i = 0; i < arr2.Length; i++)
        {
            int number = arr2[i];
            order.Add(number, i);
        }


        Array.Sort(arr1, (a, b) =>
        {

            var aHasOrder = order.TryGetValue(a, out int aOrder);
            var bHasOrder = order.TryGetValue(b, out int bOrder);

            if (aHasOrder && bHasOrder)
            {
                if (aOrder > bOrder)
                {
                    return 1;
                }
                else if (aOrder < bOrder)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (aHasOrder && bHasOrder is false)
            {
                return -1;
            }
            else if (aHasOrder is false && bHasOrder)
            {
                return 1;
            }
            else
            {
                if (a > b)
                {
                    return 1;
                }
                else if (a < b)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        });

        return arr1;

    }

}
