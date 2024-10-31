public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if(a > b)
        {
            for(int i = 0; i <= a-b; i++)
            {
                answer = answer + (int)(b+i); 
            }   
        }
        else
        {
            for(int i = 0; i <= b-a; i++)
            {
                answer = answer + (int)(a+i); 
            } 
        }
        return answer;
    }
}