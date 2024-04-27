using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        int num = 0;
        for(int i=0; i < numbers.Length; i++)
        {
            num += numbers[i];
        }
        answer = ((double)num/ (double)numbers.Length);
        return answer;
    }
}