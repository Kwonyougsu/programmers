using System;
using System.Collections.Generic;

public class Solution {
   public int solution(int[] array)
    {

        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (frequencyDict.ContainsKey(num))
                frequencyDict[num]++;
            else
                frequencyDict[num] = 1;
        }

        int maxCount = 0;
        int mostFrequentValue = -1;
        bool multipleMax = false;


        foreach (var pair in frequencyDict)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostFrequentValue = pair.Key;
                multipleMax = false;  
            }
            else if (pair.Value == maxCount)
            {
                multipleMax = true;  
            }
        }

        if (multipleMax)
            return -1;

        return mostFrequentValue;
    }
}