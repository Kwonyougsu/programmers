using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        double sqrt = Math.Sqrt(n);
        if(sqrt == Math.Floor(sqrt))
        {
            answer = (long)((sqrt+1) * (sqrt+1));
        }
        else
        {
            answer = -1;    
        }
        return answer;
    }
}