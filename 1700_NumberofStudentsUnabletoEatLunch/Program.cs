﻿// https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/description/


public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int[] studentTypeCount = new int[2];


        foreach (var s in students)
        {
            studentTypeCount[s]++;
        }

        for (int i = 0; i < sandwiches.Length; i++)
        {
            if (studentTypeCount[sandwiches[i]] == 0)
            {
                return students.Length - i;
            }

            studentTypeCount[sandwiches[i]]--;
        }

        return 0;
    }
}