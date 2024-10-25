using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;
        
        for (int i = 0; i * k <= d; i++) {
            long x = i * k;
            
            long maxY = (long)Math.Sqrt((long)d * d - x * x);
            answer += maxY / k + 1;
        }
        
        return answer;
    }
}
