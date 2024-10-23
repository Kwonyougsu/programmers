using System;

public class Solution {
    public int solution(int n) {
        int answer = (int)Math.Sqrt(n);
        if(answer * answer == n)
        {
           return 1; 
        }
        else{
            return 2;    
        }        
        return answer;
    }
}